using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;

namespace MobileSaleLibrary.Models
{
    public partial class Phone
    {
        public Phone()
        {
            TblImportInfos = new HashSet<ImportInfo>();
            TblReceiptInfos = new HashSet<ReceiptInfo>();
        }

        public Phone(int phoneId, int modelId, string type, int showPrice, Model model)
        {
            PhoneId = phoneId;
            ModelId = modelId;
            Type = type;
            ShowPrice = showPrice;
            IModelRepository mRepos = new ModelRepository();
            Model = mRepos.GetModelByID(modelId);
        }

        public int PhoneId { get; set; }
        public int ModelId { get; set; }
        public string Type { get; set; }
        public int ShowPrice { get; set; }

        public String GetPhoneName()
        {
            IModelRepository mRepos = new ModelRepository();
            Model m = mRepos.GetModelByID(this.ModelId);
            return m.ModelName;
        }
        public virtual Model Model { get; set; }
        public virtual ICollection<ImportInfo> TblImportInfos { get; set; }
        public virtual ICollection<ReceiptInfo> TblReceiptInfos { get; set; }
    }
}
