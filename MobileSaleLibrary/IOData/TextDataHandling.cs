using MobileSaleLibrary.Models;

namespace MobileSaleLibrary.IOData
{
    public class DataString
    {
        public static List<string> StringSplitter(string temp)
        {
            List<string> result;
            try
            {
                result = new List<string>();
                string[] SplitMethodHandling = temp.Split(',');
                foreach (string s in SplitMethodHandling)
                {
                    result.Add(s);
                }
                if (result.Count == 0)
                {
                    throw new Exception("Empty result.");
                }
            }
            catch (Exception ex)
            {
                result = new List<string> { "*Ex:*" + ex.Message, temp };
            }
            return result;
        }

        public static Customer? CConvert(string temp)
        {
            Customer? result;
            try
            {
                result = new Customer();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        if (data.Count != 5)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        result.CustomerId = int.Parse(data[0]);
                        bool GenderCheck = data[4].Equals("Male") || data[4].Equals("Female") || data[4].Equals("X");
                        if (!GenderCheck)
                        {
                            throw new Exception("Data field gender is corrupted.");
                        }
                        else
                        {
                            result.Gender = data[4];
                        }
                        result.CustomerName = data[1];
                        result.CustomerPhoneNumber = data[2];
                        result.CustomerAddress = data[3];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Customer.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }
        public static Import? IConvert(string temp)
        {
            Import? result;
            try
            {
                result = new Import();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        if (data.Count != 3)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        result.ImportId = int.Parse(data[0]);
                        result.ImportDate = DateTime.Parse(data[1]);
                        result.SupplierId = int.Parse(data[2]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Import.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static Receipt? RConvert(string temp)
        {
            Receipt? result;
            try
            {
                result = new Receipt();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        //Number of field in object
                        if (data.Count != 3)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        //Push data
                        result.ReceiptId = int.Parse(data[0]);
                        result.ReceiptDate = DateTime.Parse(data[1]);
                        result.CustomerId = int.Parse(data[2]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Receipt.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static ImportInfo? IIConvert(string temp)
        {
            ImportInfo? result;
            try
            {
                result = new ImportInfo();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        //Number of field in object
                        if (data.Count != 4)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        //Push data
                        result.ImportId = int.Parse(data[0]);
                        result.PhoneId = int.Parse(data[1]);
                        result.BuyPricePerUnit = int.Parse(data[2]);
                        result.Quantity = int.Parse(data[3]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to ImportInfo.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static ReceiptInfo? RIConvert(string temp)
        {
            ReceiptInfo? result;
            try
            {
                result = new ReceiptInfo();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        //Number of field in object
                        if (data.Count != 4)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        //Push data
                        result.ReceiptId = int.Parse(data[0]);
                        result.PhoneId = int.Parse(data[1]);
                        result.SellPricePerUnit = int.Parse(data[2]);
                        result.Quantity = int.Parse(data[3]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to ReceiptInfo.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }
        public static Supplier? SConvert(string temp)
        {
            Supplier? result;
            try
            {
                result = new Supplier();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        if (data.Count != 4)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        result.SupplierId = int.Parse(data[0]);
                        result.SupplierName = data[1];
                        result.SupplierPhoneNumber = data[2];
                        result.SupplierAddress = data[3];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Supplier.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static Phone? PConvert(string temp)
        {
            Phone? result;
            try
            {
                result = new Phone();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        if (data.Count != 4)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        result.PhoneId = int.Parse(data[0]);
                        result.ModelId = int.Parse(data[1]);
                        result.Type = data[2];
                        result.ShowPrice = int.Parse(data[3]);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Phone.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        public static Model? MConvert(string temp)
        {
            Model? result;
            try
            {
                result = new Model();
                List<string> data = StringSplitter(temp);
                if (data.Count == 2 && data[0].Contains("*Ex:*") && data[1].Equals(temp))
                {
                    throw new Exception("SpliterException:\n" + data[0]);
                }
                else
                {
                    try
                    {
                        if (data.Count != 5)
                        {
                            throw new Exception("Number of field inappropriate.");
                        }
                        result.ModelId = int.Parse(data[0]);
                        result.ModelName = data[1];
                        result.ModelOrigin = data[2];
                        result.ModelYearOfWarranty = int.Parse(data[3]);
                        result.ModelBrand = data[4];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("String is not compatible to convert to Model.\n" +
                                            ex);
                    }
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}