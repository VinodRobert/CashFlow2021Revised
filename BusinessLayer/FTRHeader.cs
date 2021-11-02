using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.BusinessLayer
{
    class FTRHeaderList
    {
        int _ftrID;
        string _borgName;
        string _ftrNumber;
        DateTime _createDate;
        DateTime _lastUpdate;
        string _ftrStatus;

        public int FTRID
        {
            get { return _ftrID; }
            set { _ftrID = value; }
        } 

        public string BORGNAME
        {
            get { return _borgName; }
            set { _borgName = value; }
        }

        public string FTRNUMBER
        {
            get { return _ftrNumber; }
            set { _ftrNumber = value; }
        }

        public DateTime CREATEDATE
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public DateTime LASTUPDATE
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

        public string FTRSTATUS
        {
            get { return _ftrStatus; }
            set { _ftrStatus = value; }
        }


    }
}
