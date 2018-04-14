//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml.Linq;
//using System.Timers;
//using System.Diagnostics;
//using System.IO;
//using VHPLabelPrinter;
//using VHPLabelPrinter.Data;
//using VHPLabelPrinter.DataObjects;
//using VHPLabelPrinter.Printing;
//using VHPLabelPrinter.Entities;

//namespace VHPLabelWriter.Factories
//{
//    public class LabelRolFactory
//    {
//        private const string booleanYes = "\"Y\"";
//        public string Message { get; set; }
//        private LabelRol labelRol;

//        /// <summary>
//        /// Creates a stuklijst. Once the stuklijst has been created it can be accessed from the Stuklijst property.
//        /// </summary>
//        /// <param name="file"></param>
//        /// <returns></returns>
//        public LabelRol Create(UserInput input)
//        {
//            RawData rawData = new FileReader().Read(input.FileName);

//            labelRol = new LabelRol(input.BatchNumber, input.AantalProducten);
//            labelRol.BillOfMaterialsFor = rawData.BillOfMaterialsFor;
//            labelRol.Variant = rawData.Variant;

//            //CreateBatchlabel(rawData, input.BatchNumber, input.AantalProducten, input.AantalBatchLabels);

//            if (input.AfkomstPastaScreen == "VHP")
//            {
//                CreateScreenlabel(rawData.BillOfMaterialsFor);
//            }

//            //de artikelen lezen
//            CreateItemLabels(input.BatchNumber, input.AantalProducten, input.OverleveringAbsoluut, input.OverleveringRelatief, input.ComponentTypes, rawData);
//            return labelRol;
//        }

//        private void CreateScreenlabel(string prodNaam)
//        {
//            labelRol.Labels.Add(new PastaScreenLabel { ProductName = prodNaam, JobDate = DateTime.Now.ToString("dd-MM-yyyy") });
//        }

//        private void CreateBatchlabel(RawData rawData, string batchNumber, int numberOfProducts, int numberOfProjectLabels)
//        {
//            for (int index = 0; index < numberOfProjectLabels; index++)
//            {
//                CreatePartOne(numberOfProducts, batchNumber);
//                CreatePartTwo(rawData);
//            }
//        }

//        private void CreatePartOne(int numberOfProducts, string batchNumber)
//        {
//            BatchLabel1 label = new BatchLabel1();
//            label.BatchNumber = batchNumber;
//            label.NumberOfProducts = numberOfProducts.ToString();
//            labelRol.Labels.Add(label);
//        }

//        private void CreatePartTwo(RawData rawData)
//        {
//            BatchLabel2 label = new BatchLabel2();
//            label.Product = rawData.BillOfMaterialsFor;
//            label.Variant = rawData.Variant;
//            labelRol.Labels.Add(label);
//        }

//        private void CreateItemLabels(string batchNumber, int numberOfProducts, int overleveringAbsoluut, int overleveringRelatief, List<ComponentType> componentTypes, RawData rawData)
//        {
//            var rows = SelectRows(componentTypes, rawData);
//            int labelIndex = 1;
//            foreach (DataRow row in rows)
//            {
//                if (!row.SupplVhp.Equals("I", StringComparison.InvariantCultureIgnoreCase)) //I betekent ignore
//                {
//                    string needed = string.Empty;
//                    string adviced = string.Empty;
//                    if (!string.IsNullOrEmpty(row.Needed))
//                    {
//                        needed = (Convert.ToDecimal(row.Needed) * numberOfProducts).ToString();
//                        adviced = GetAdvise(row.Needed, overleveringAbsoluut, overleveringRelatief, numberOfProducts);
//                    }

//                    if (LabelNeedsPrinting(row.SupplVhp))
//                    {
//                        //labelRol.AddLabel(row.PartNo, needed, adviced, row.IsSmd == booleanYes, batchNumber);
//                        labelRol.AddLabel(row.PartNo, needed, adviced, row.Type == ComponentType.Smd, batchNumber);
//                    }
//                }
//                labelIndex++;
//            }
//        }

//        private bool LabelNeedsPrinting(string leverenVhp)
//        {
//            if (leverenVhp == "Y" || leverenVhp == "A")
//            {
//                return true;
//            }
//            return false;
//        }

//        private IEnumerable<DataRow> SelectRows(List<ComponentType> componentTypes, RawData rawData)
//        {
//            List<DataRow> rows = new List<DataRow>();
//            if (componentTypes.Contains(ComponentType.Smd))
//            {
//                rows.AddRange(rawData.Rows.Where(row => row.Type == ComponentType.Smd));
//            }

//            if (componentTypes.Contains(ComponentType.NonSmd))
//            {
//                rows.AddRange(rawData.Rows.Where(row => row.Type == ComponentType.NonSmd));
//            }

//            if (componentTypes.Contains(ComponentType.Mechanisch))
//            {
//                rows.AddRange(rawData.Rows.Where(row => row.Type == ComponentType.Mechanisch));
//            }

//            //switch (componentType)
//            //{
//            //    case ComponentType.NonSmd:
//            //        rows = rawData.Rows.Where(row => !IsBooleanYes(row.IsSmd));
//            //        break;
//            //    case ComponentType.Smd:
//            //        rows = rawData.Rows.Where(row => IsBooleanYes(row.IsSmd));
//            //        break;
//            //    default:
//            //        rows = rawData.Rows;
//            //        break;
//            //}
//            return rows;
//        }

//        private string GetAdvise(string numberNeededPerProduct, int overleveringAbsoluut, int overleveringRelatief, int numberOfProducts)
//        {
//            int needed;
//            bool isNumeric = Int32.TryParse(numberNeededPerProduct, out needed);
//            if (isNumeric)
//            {
//                double adviced = Math.Round(needed + overleveringAbsoluut + 0.01 * overleveringRelatief * needed, 0) * numberOfProducts;
//                return adviced.ToString();
//            }

//            return string.Empty;
//        }

//        //private bool IsBooleanYes(string value)
//        //{
//        //    if (value.ToUpper() == "Y" || value.ToUpper() == "\"Y\"")
//        //    {
//        //        return true;
//        //    }
//        //    return false;
//        //}
//    }
//}
