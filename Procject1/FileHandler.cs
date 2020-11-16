using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Procject1
{
    class FileHandler
    {
         #region Fields
        StreamReader reader;
        StreamWriter writer;
        FileStream stream;
        string filePathPrime;
        #endregion

        #region Constructors
        public FileHandler(string filePath = "default.txt")
        {
            this.filePathPrime = filePath;
        }

        public FileHandler()
        {

        }
        #endregion

        #region methods

        public List<string> ReadData(string filePath)
        {
            List<string> data = new List<string>();
            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }
            finally
            {
                reader.Close();
                stream.Close();
            }

            return data;
        }


        
         public void WriteData(List<string> data, string fileName, bool isAppend)
        {
            try
            {
                if (isAppend)
                    stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                else
                   stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                foreach (string s in data)
                    writer.WriteLine(s);
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }
            
            finally
            {
                  writer.Close();
                  stream.Close();
            }
        }


         //public void GetEmployees()
         //{
         //    FileHandler fa = new FileHandler();
             
         //    foreach (string item in fa.ReadData("EmployeeList.txt"))
         //    {
         //        string[] splitter = item.Split(',');
         //        string emptype = splitter[0];
         //        if (emptype.ToUpper() == "P" )
         //        {
         //            string name = splitter[1];
         //            double payrate = Convert.ToDouble(splitter[2]);
         //            int hW = Convert.ToInt32(splitter[3] + splitter[4] + splitter[5]+splitter[6] + splitter[7]);
         //            string psts = splitter[8];
         //            List<Programmer> prg = new List<Programmer>();
         //            prg.Add(new Programmer(name, payrate, hW, emptype, psts));

         //        }
         //        else if (emptype.ToUpper() == "M")
         //        {
         //            string name = splitter[1];
         //            double payrate = Convert.ToDouble(splitter[2]);
         //            int hW = Convert.ToInt32(splitter[3] + splitter[4] + splitter[5] + splitter[6] + splitter[7]);
         //            int sales = Convert.ToInt32(splitter[8]);
         //            List<MarketingEmp> mrk = new List<MarketingEmp>();
         //            mrk.Add(new MarketingEmp(name,payrate, hW, emptype, sales));

         //        }
         //        else if (emptype.ToUpper() == "G")
         //        {
         //            string name = splitter[1];
         //            double payrate = Convert.ToDouble(splitter[2]);
         //            int hW = Convert.ToInt32(splitter[3] + splitter[4] + splitter[5] + splitter[6] + splitter[7]);
         //            string psts = splitter[8];
         //            List<GeneralEmp> gen = new List<GeneralEmp>();
         //            gen.Add(new GeneralEmp(name, payrate, hW, emptype));

         //        }

         //    }
         //}

         List<string> info = new List<string>();
         bool isTrue;
         public bool LoginAttempt(string UserNameP, string PassP)
         {

             info =  ReadData("login.txt");
             foreach (var item in info)
             {
                 string[] spliter = item.Split(',');
                 if (UserNameP == spliter[0] && PassP == spliter[1]) 
                 {
                     isTrue = true;
                 }
             }
             return isTrue;
         }

        #endregion
    }
}
