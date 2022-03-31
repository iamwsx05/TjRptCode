using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Net;
using System.Web.Services.Description;

namespace weCare.Core.Utils
{
    public class WebServiceHelper
    {
        public static object WebserviceInvoke(string p_strUrl, string p_strMethodName, object[] p_objArgs)
        {
            return WebserviceInvoke(p_strUrl, "", "", p_strMethodName, p_objArgs);
        }

        public static object WebserviceInvoke(string p_strUrl, string p_strNameSpace, string p_strClassName, string p_strMethodName, object[] p_objArgs)
        {
            object oReturnValue = null;
            try
            {
                if (p_strNameSpace == "")
                {
                    p_strNameSpace = "EnterpriseServerBase.WebService.DynamicWebCalling";
                }
                if (p_strClassName == "")
                {
                    p_strClassName = WebServiceHelper.GetWsClassName(p_strUrl);
                }
                System.Net.WebClient wc = new System.Net.WebClient();
                System.IO.Stream stream = wc.OpenRead(p_strUrl + "?wsdl");
                System.Web.Services.Description.ServiceDescription sd = System.Web.Services.Description.ServiceDescription.Read(stream);
                System.Web.Services.Description.ServiceDescriptionImporter sdi = new System.Web.Services.Description.ServiceDescriptionImporter();
                sdi.AddServiceDescription(sd, "", "");
                System.CodeDom.CodeNamespace cn = new System.CodeDom.CodeNamespace(p_strNameSpace);
                System.CodeDom.CodeCompileUnit ccu = new System.CodeDom.CodeCompileUnit();
                ccu.Namespaces.Add(cn);
                sdi.Import(cn, ccu);

                Microsoft.CSharp.CSharpCodeProvider csc = new Microsoft.CSharp.CSharpCodeProvider();
                System.CodeDom.Compiler.CompilerParameters cplist = new System.CodeDom.Compiler.CompilerParameters();
                cplist.GenerateExecutable = false;
                cplist.GenerateInMemory = true;
                cplist.ReferencedAssemblies.Add("System.dll");
                cplist.ReferencedAssemblies.Add("System.XML.dll");
                cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
                cplist.ReferencedAssemblies.Add("System.Data.dll");

                System.CodeDom.Compiler.CompilerResults cr = csc.CompileAssemblyFromDom(cplist, ccu);
                if (true == cr.Errors.HasErrors)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                    {
                        sb.Append(ce.ToString());
                        sb.Append(System.Environment.NewLine);
                    }
                    throw new Exception(sb.ToString());
                }
                System.Reflection.Assembly assembly = cr.CompiledAssembly;
                Type t = assembly.GetType(p_strNameSpace + "." + p_strClassName, true, true);
                object obj = Activator.CreateInstance(t);
                System.Reflection.MethodInfo mi = t.GetMethod(p_strMethodName);
                oReturnValue = mi.Invoke(obj, p_objArgs);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, new Exception(ex.InnerException.StackTrace));
            }
            return oReturnValue;
        }

        private static string GetWsClassName(string p_strUrl)
        {
            string[] parts = p_strUrl.Split('/');
            string[] pps = parts[parts.Length - 1].Split('.');
            return pps[0];
        }

        /// <summary<   
        /// 实例化WebServices   
        /// </summary<   
        /// <param name="url"<WebServices地址</param<   
        /// <param name="methodname"<调用的方法</param<   
        /// <param name="args"<把webservices里需要的参数按顺序放到这个object[]里</param<   
        public static object InvokeWebService(string url, string methodname, object[] args)
        {
            //这里的namespace是需引用的webservices的命名空间，在这里是写死的，大家可以加一个参数从外面传进来。   
            string @namespace = "client";
            try
            {
                //获取WSDL   
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(url + "?WSDL");
                ServiceDescription sd = ServiceDescription.Read(stream);
                string classname = sd.Services[0].Name;
                ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
                sdi.AddServiceDescription(sd, "", "");
                CodeNamespace cn = new CodeNamespace(@namespace);

                //生成客户端代理类代码   
                CodeCompileUnit ccu = new CodeCompileUnit();
                ccu.Namespaces.Add(cn);
                sdi.Import(cn, ccu);
                CSharpCodeProvider csc = new CSharpCodeProvider();
                ICodeCompiler icc = csc.CreateCompiler();

                //设定编译参数   
                CompilerParameters cplist = new CompilerParameters();
                cplist.GenerateExecutable = false;
                cplist.GenerateInMemory = true;
                cplist.ReferencedAssemblies.Add("System.dll");
                cplist.ReferencedAssemblies.Add("System.XML.dll");
                cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
                cplist.ReferencedAssemblies.Add("System.Data.dll");

                //编译代理类   
                CompilerResults cr = icc.CompileAssemblyFromDom(cplist, ccu);
                if (true == cr.Errors.HasErrors)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                    {
                        sb.Append(ce.ToString());
                        sb.Append(System.Environment.NewLine);
                    }
                    throw new Exception(sb.ToString());
                }

                //生成代理实例，并调用方法   
                System.Reflection.Assembly assembly = cr.CompiledAssembly;
                Type t = assembly.GetType(@namespace + "." + classname, true, true);
                object obj = Activator.CreateInstance(t);
                System.Reflection.MethodInfo mi = t.GetMethod(methodname);

                return mi.Invoke(obj, args);
            }
            catch
            {
                return null;
            }
        }
    }
}
