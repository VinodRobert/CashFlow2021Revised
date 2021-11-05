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
        string _custoidan;
        string _forEdit;
        string _forExport;
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

        public string CUSTODIAN
        {
            get { return _custoidan; }
            set { _custoidan = value; }
        }
        public string FOREDIT
        {
            get { return _forEdit; }
            set { _forEdit = value; }
        }

        public string FOREXPORT
        {
            get { return _forExport; }
            set { _forExport = value; }
        }
    }

    class SingleFTR
    {
        int _resultID;
        string _majorCategory;
        string _minorCategory;
        string _category;
        string _vendorType;
        string _partyCode;
        string _partyName;
        decimal _netPayable;
        decimal _paid;
        decimal _projectLiability;
        decimal _gstCredit;
        decimal _companyLiability;
        decimal _payableAfterGST;
        decimal _finalPayable;
        decimal _mobAdvance;
        decimal _projectSite;
        decimal _accountant;
        int     _controlCell;
        int    _accountsHead;
        int _lineOrder;

        public int RESULTID
        {
            get { return _resultID; }
            set { _resultID = value; }
        }
        public string MAJORCATEGORY
        {
            get { return _majorCategory; }
            set { _majorCategory = value; }
        }
        public string MINORCATEGORY
        {
            get { return _minorCategory; }
            set { _minorCategory = value; }
        }
        public string CATEGORY
        {
            get { return _category; }
            set { _category = value; }
        }
        public string VENDORTYPE
        {
            get { return _vendorType; }
            set { _vendorType = value; }
        }
        public string PARTYCODE
        {
            get { return _partyCode; }
            set { _partyCode = value; }
        }
        public string PARTYNAME
        {
            get { return _partyName; }
            set { _partyName = value; }
        }
        public decimal NETPAYABLE
        {
            get { return _netPayable; }
            set { _netPayable = value; }
        }

        public decimal PAID
        {
            get { return _paid; }
            set { _paid = value; }
        }

        public decimal PROJECTLIABILITY
        {
            get { return _projectLiability; }
            set { _projectLiability = value; }
        }

        public decimal GSTCREDIT
        {
            get { return _gstCredit; }
            set { _gstCredit = value; }
        }

        public decimal COMPANYLIABILITY
        {
            get { return _companyLiability; }
            set { _companyLiability = value; }
        }

        public decimal PAYABLEAFTERGST
        {
            get { return _payableAfterGST; }
            set { _payableAfterGST = value; }
        }

        public decimal FINALPAYABLE
        {
            get { return _finalPayable; }
            set { _finalPayable = value; }
        }

        public decimal MOBADVANCE
        {
            get { return _mobAdvance; }
            set { _mobAdvance = value; }
        }

        public decimal PROJECTSITE
        {
            get { return _projectSite; }
            set { _projectSite = value; }
        }

        public decimal ACCOUNTANT
        {
            get { return _accountant; }
            set { _accountant = value; }
        }

        
        public int ACCOUNTSHEAD
        {
            get { return _accountsHead; }
            set { _accountsHead = value; }
        }


        public int CONTROLCELL
        {
            get { return _controlCell; }
            set { _controlCell = value; }
        }

      

        public int LINEORDER
        {
            get { return _lineOrder; }
            set { _lineOrder = value; }
        }

    }
}
