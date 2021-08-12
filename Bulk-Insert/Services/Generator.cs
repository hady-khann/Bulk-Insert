using Bulk_Insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bulk_Insert.Services
{
    public class Generator : IDisposable
    {
        public List<TblPerson> people = new List<TblPerson>();

        //public DataTable table = new DataTable();

        Random rnd = new Random();

        public void gen_list()
        {
            #region Threads Definition
            Thread t0 = new Thread(() => gen_record());
            Thread t1 = new Thread(() => gen_record());
            Thread t2 = new Thread(() => gen_record());
            Thread t3 = new Thread(() => gen_record());
            Thread t4 = new Thread(() => gen_record());
            Thread t5 = new Thread(() => gen_record());
            Thread t6 = new Thread(() => gen_record());
            Thread t7 = new Thread(() => gen_record());
            Thread t8 = new Thread(() => gen_record());
            Thread t9 = new Thread(() => gen_record());
            Thread t10 = new Thread(() => gen_record());
            Thread t11 = new Thread(() => gen_record());
            Thread t12 = new Thread(() => gen_record());
            Thread t13 = new Thread(() => gen_record());
            Thread t14 = new Thread(() => gen_record());
            Thread t15 = new Thread(() => gen_record());
            Thread t16 = new Thread(() => gen_record());
            Thread t17 = new Thread(() => gen_record());
            Thread t18 = new Thread(() => gen_record());
            Thread t19 = new Thread(() => gen_record());
            #endregion

            #region Threads Priority
            t0.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Highest;
            t4.Priority = ThreadPriority.Highest;
            t5.Priority = ThreadPriority.Highest;
            t6.Priority = ThreadPriority.Highest;
            t7.Priority = ThreadPriority.Highest;
            t8.Priority = ThreadPriority.Highest;
            t9.Priority = ThreadPriority.Highest;
            t10.Priority = ThreadPriority.Highest;
            t11.Priority = ThreadPriority.Highest;
            t12.Priority = ThreadPriority.Highest;
            t13.Priority = ThreadPriority.Highest;
            t14.Priority = ThreadPriority.Highest;
            t15.Priority = ThreadPriority.Highest;
            t16.Priority = ThreadPriority.Highest;
            t17.Priority = ThreadPriority.Highest;
            t18.Priority = ThreadPriority.Highest;
            t19.Priority = ThreadPriority.Highest;
            #endregion

            #region Threads Strat
            t0.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
            t11.Start();
            t12.Start();
            t13.Start();
            t14.Start();
            t15.Start();
            t16.Start();
            t17.Start();
            t18.Start();
            t19.Start();
            #endregion

            #region Threads Join
            t0.Join();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();
            t10.Join();
            t11.Join();
            t12.Join();
            t13.Join();
            t14.Join();
            t15.Join();
            t16.Join();
            t17.Join();
            t18.Join();
            t19.Join();
            #endregion

        }

        private void gen_record()
        {
            //table.TableName = "People";

            //table.Columns.Add("id", typeof(string));
            //table.Columns.Add("Fname", typeof(string));
            //table.Columns.Add("Lname", typeof(string));
            //table.Columns.Add("Faname", typeof(string));
            //table.Columns.Add("Age", typeof(int));
            //table.Columns.Add("Grade", typeof(int));
            //table.Columns.Add("Address", typeof(string));

            //for (int i = 0; i < 1000; i++)
            //{
            //    var row = table.NewRow();
            //    row["id"] = rand_id();
            //    row["Fname"] = rand_string(3,10);
            //    row["Lname"] = rand_string(4, 20);
            //    row["Faname"] = rand_string(3, 10);
            //    row["Age"] = rand_num(100);
            //    row["Grade"] = rand_num(30);
            //    row["Address"] = rand_string(100,200);

            //    table.Rows.Add(row);
            //}


            for (int i = 0; i < 60000; i++)
            {
                people.Add(new TblPerson
                {
                    Id = rand_id(),
                    Fname = rand_string(3, 10),
                    Lname = rand_string(4, 20),
                    Faname = rand_string(3, 10),
                    Age = rand_num(100),
                    Grade = rand_num(30),
                    Address = rand_string(100, 200)
                });

            }
        }

        private string rand_string(int min_legth, int max_length)
        {
            string value = string.Empty;

            int length = rnd.Next(min_legth, max_length);

            for (int i = 0; i < length; i++)
            {
                value += (char)rnd.Next(97, 122);
            }

            return value;
        }

        private int rand_num(int max)
        {
            return rnd.Next(1, max);
        }

        private string rand_id()
        {
            return "" + DateTime.Now.ToString("Hmsff") + rnd.Next(10, 99) + rnd.Next(10, 99);
        }

        public void Dispose()
        {
        }
    }
}
