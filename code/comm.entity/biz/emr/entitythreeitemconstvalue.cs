using System;
using System.Runtime.Serialization;

namespace Common.Entity
{
    [DataContract, Serializable]
    public class EntityThreeItemConstValue : weCare.Core.Entity.BaseDataContract
    {
        private int int4From = 0 * 60 * 60;
        private int int4To = 4 * 60 * 60 - 1;
        private int int8From = 4 * 60 * 60;
        private int int8To = 8 * 60 * 60 - 1;
        private int int12From = 8 * 60 * 60;
        private int int12To = 12 * 60 * 60 - 1;
        private int int16From = 12 * 60 * 60;
        private int int16To = 16 * 60 * 60 - 1;
        private int int20From = 16 * 60 * 60;
        private int int20To = 20 * 60 * 60 - 1;
        private int int24From = 20 * 60 * 60;
        private int int24To = 24 * 60 * 60 - 1;

        public EntityThreeItemConstValue()
        {
            if (GlobalParm.dicSysParameter != null && GlobalParm.dicSysParameter.ContainsKey(33) && GlobalParm.dicSysParameter[33] == "1")
            {
                int4From = 2 * 60 * 60;
                int4To = 6 * 60 * 60 - 1;
                int8From = 6 * 60 * 60;
                int8To = 10 * 60 * 60 - 1;
                int12From = 10 * 60 * 60;
                int12To = 14 * 60 * 60 - 1;
                int16From = 14 * 60 * 60;
                int16To = 18 * 60 * 60 - 1;
                int20From = 18 * 60 * 60;
                int20To = 22 * 60 * 60 - 1;
                int24From = 22 * 60 * 60;
                int24To = 2 * 60 * 60 - 1;
            }
        }

        [DataMember]
        public int TimeSpan_4_From
        {
            get { return int4From; }
            set { int4From = value; }
        }
        [DataMember]
        public int TimeSpan_4_To
        {
            get { return int4To; }
            set { int4To = value; }
        }
        [DataMember]
        public int TimeSpan_8_From
        {
            get { return int8From; }
            set { int8From = value; }
        }
        [DataMember]
        public int TimeSpan_8_To
        {
            get { return int8To; }
            set { int8To = value; }
        }
        [DataMember]
        public int TimeSpan_12_From
        {
            get { return int12From; }
            set { int12From = value; }
        }
        [DataMember]
        public int TimeSpan_12_To
        {
            get { return int12To; }
            set { int12To = value; }
        }
        [DataMember]
        public int TimeSpan_16_From
        {
            get { return int16From; }
            set { int16From = value; }
        }
        [DataMember]
        public int TimeSpan_16_To
        {
            get { return int16To; }
            set { int16To = value; }
        }
        [DataMember]
        public int TimeSpan_20_From
        {
            get { return int20From; }
            set { int20From = value; }
        }
        [DataMember]
        public int TimeSpan_20_To
        {
            get { return int20To; }
            set { int20To = value; }
        }
        [DataMember]
        public int TimeSpan_24_From
        {
            get { return int24From; }
            set { int24From = value; }
        }
        [DataMember]
        public int TimeSpan_24_To
        {
            get { return int24To; }
            set { int24To = value; }
        }
    }
}
