using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.BusinessLayer
{
    public class SelectedRowInformation
    {

        public SelectedRowInformation(string structureKey, string flowCategory, string level1, string level2)
        {
            StructureKey = structureKey;
            FlowCategory = flowCategory;
            Level1 = level1;
            Level2 = level2;
        }
        private string m_structureKey;
        public string StructureKey
        {
            get { return m_structureKey; }
            set { m_structureKey = value; }
        }

        private string m_flowCategory;
        public string FlowCategory
        {
            get { return m_flowCategory; }
            set { m_flowCategory = value; }
        }

        private string m_level1;
        public string Level1
        {
            get { return m_level1; }
            set { m_level1 = value; }
        }

        private string m_level2;
        public string Level2
        {
            get { return m_level2; }
            set { m_level2 = value; }
        }
       
    }
    class GenericClassess
    {
    }


}
