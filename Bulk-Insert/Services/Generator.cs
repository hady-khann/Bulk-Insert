using Bulk_Insert.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bulk_Insert.Services
{
    public class Generator : IDisposable
    {
        public List<TblPerson> people = new List<TblPerson>();
        List<int> transaction_records_count = new List<int>();

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
            Thread t20 = new Thread(() => gen_record());
            Thread t21 = new Thread(() => gen_record());
            Thread t22 = new Thread(() => gen_record());
            Thread t23 = new Thread(() => gen_record());
            Thread t24 = new Thread(() => gen_record());
            Thread t25 = new Thread(() => gen_record());
            Thread t26 = new Thread(() => gen_record());
            Thread t27 = new Thread(() => gen_record());
            Thread t28 = new Thread(() => gen_record());
            Thread t29 = new Thread(() => gen_record());
            Thread t30 = new Thread(() => gen_record());
            Thread t31 = new Thread(() => gen_record());
            Thread t32 = new Thread(() => gen_record());
            Thread t33 = new Thread(() => gen_record());
            Thread t34 = new Thread(() => gen_record());
            Thread t35 = new Thread(() => gen_record());
            Thread t36 = new Thread(() => gen_record());
            Thread t37 = new Thread(() => gen_record());
            Thread t38 = new Thread(() => gen_record());
            Thread t39 = new Thread(() => gen_record());
            Thread t40 = new Thread(() => gen_record());
            Thread t41 = new Thread(() => gen_record());
            Thread t42 = new Thread(() => gen_record());
            Thread t43 = new Thread(() => gen_record());
            Thread t44 = new Thread(() => gen_record());
            Thread t45 = new Thread(() => gen_record());
            Thread t46 = new Thread(() => gen_record());
            Thread t47 = new Thread(() => gen_record());
            Thread t48 = new Thread(() => gen_record());
            Thread t49 = new Thread(() => gen_record());
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
            t20.Priority = ThreadPriority.Highest;
            t21.Priority = ThreadPriority.Highest;
            t22.Priority = ThreadPriority.Highest;
            t23.Priority = ThreadPriority.Highest;
            t24.Priority = ThreadPriority.Highest;
            t25.Priority = ThreadPriority.Highest;
            t26.Priority = ThreadPriority.Highest;
            t27.Priority = ThreadPriority.Highest;
            t28.Priority = ThreadPriority.Highest;
            t29.Priority = ThreadPriority.Highest;
            t30.Priority = ThreadPriority.Highest;
            t31.Priority = ThreadPriority.Highest;
            t32.Priority = ThreadPriority.Highest;
            t33.Priority = ThreadPriority.Highest;
            t34.Priority = ThreadPriority.Highest;
            t35.Priority = ThreadPriority.Highest;
            t36.Priority = ThreadPriority.Highest;
            t37.Priority = ThreadPriority.Highest;
            t38.Priority = ThreadPriority.Highest;
            t39.Priority = ThreadPriority.Highest;
            t40.Priority = ThreadPriority.Highest;
            t41.Priority = ThreadPriority.Highest;
            t42.Priority = ThreadPriority.Highest;
            t43.Priority = ThreadPriority.Highest;
            t44.Priority = ThreadPriority.Highest;
            t45.Priority = ThreadPriority.Highest;
            t46.Priority = ThreadPriority.Highest;
            t47.Priority = ThreadPriority.Highest;
            t48.Priority = ThreadPriority.Highest;
            t49.Priority = ThreadPriority.Highest;
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
            t20.Start();
            t21.Start();
            t22.Start();
            t23.Start();
            t24.Start();
            t25.Start();
            t26.Start();
            t27.Start();
            t28.Start();
            t29.Start();
            t30.Start();
            t31.Start();
            t32.Start();
            t33.Start();
            t34.Start();
            t35.Start();
            t36.Start();
            t37.Start();
            t38.Start();
            t39.Start();
            t40.Start();
            t41.Start();
            t42.Start();
            t43.Start();
            t44.Start();
            t45.Start();
            t46.Start();
            t47.Start();
            t48.Start();
            t49.Start();
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
            t20.Join();
            t21.Join();
            t22.Join();
            t23.Join();
            t24.Join();
            t25.Join();
            t26.Join();
            t27.Join();
            t28.Join();
            t29.Join();
            t30.Join();
            t31.Join();
            t32.Join();
            t33.Join();
            t34.Join();
            t35.Join();
            t36.Join();
            t37.Join();
            t38.Join();
            t39.Join();
            t40.Join();
            t41.Join();
            t42.Join();
            t43.Join();
            t44.Join();
            t45.Join();
            t46.Join();
            t47.Join();
            t48.Join();
            t49.Join();
            #endregion

        }

        public void logger(string Execution_ID,int dbcount , string time , string ttime)
        {
            StreamWriter writer = null;
            string path = @"C:\Users\Hady_khann\source\repos\Log.txt";
            int Generated_Recordes = people.Count();
            int count_all=0;

            transaction_records_count.Add(Generated_Recordes);


            foreach (var item in transaction_records_count)
            {
                count_all += item;
            }


            using (writer = File.AppendText(path))
            {
                writer.WriteLine(Execution_ID + ":::" +"Generated Recordes : " + Generated_Recordes + " ||| DB Total Records : " + dbcount +
                    " |||  ekhtelaf :  " + (dbcount - count_all) + " ||| Spent Time  : " + time + " ||| Total Time  : " + ttime +  Environment.NewLine);
            }
            writer.Close();
            writer.Dispose();


        }

        public SqlConnection Get_Connection()
        {
            return new SqlConnection("Server=.;Database=FakeDB;Trusted_Connection=True;");
        }





        private void gen_record()
        {
            for (int i = 1; i <= 10100; i++)
            {

                try
                {
                    people.Add(new TblPerson
                    {
                        Fname = rand_string(4, 10),
                        Lname = rand_string(5, 20),
                        Faname = rand_string(3, 10),
                        Age = rand_num(100),
                        Grade = rand_num(30),
                        Address = rand_string(150, 200)
                    });
                }
                catch (Exception)
                {
                    continue;
                }
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
            return rnd.Next(2, max);
        }

        public void Dispose()
        {
        }
    }
}
