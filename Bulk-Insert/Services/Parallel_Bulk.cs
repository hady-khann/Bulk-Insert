using Bulk_Insert.Models;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bulk_Insert.Services
{
    public class Parallel_Bulk : IDisposable
    {
        bool locked = false;

        private readonly FakeDBContext _context;

        public Parallel_Bulk() { }


        public Parallel_Bulk(FakeDBContext context)
        {
            _context = context;
        }



        public void Bulk_InTo_DB()
        {
            #region Threads Definition
            Thread t0 = new Thread(() => Bulking("00"));
            Thread t1 = new Thread(() => Bulking("01"));
            Thread t2 = new Thread(() => Bulking("02"));
            Thread t3 = new Thread(() => Bulking("03"));
            Thread t4 = new Thread(() => Bulking("04"));
            Thread t5 = new Thread(() => Bulking("05"));
            //Thread t6 = new Thread(() => Bulking("06"));
            //Thread t7 = new Thread(() => Bulking("07"));
            //Thread t8 = new Thread(() => Bulking("08"));
            //Thread t9 = new Thread(() => Bulking("09"));
            //Thread t10 = new Thread(() => Bulking("10"));
            //Thread t11 = new Thread(() => Bulking("11"));
            //Thread t12 = new Thread(() => Bulking("12"));
            //Thread t13 = new Thread(() => Bulking("13"));
            //Thread t14 = new Thread(() => Bulking("14"));
            //Thread t15 = new Thread(() => Bulking("15"));
            //Thread t16 = new Thread(() => Bulking("16"));
            //Thread t17 = new Thread(() => Bulking("17"));
            //Thread t18 = new Thread(() => Bulking("18"));
            //Thread t19 = new Thread(() => Bulking("19"));
            //Thread t20 = new Thread(() => Bulking("10"));
            //Thread t21 = new Thread(() => Bulking("21"));
            //Thread t22 = new Thread(() => Bulking("22"));
            //Thread t23 = new Thread(() => Bulking("23"));
            //Thread t24 = new Thread(() => Bulking("24"));
            //Thread t25 = new Thread(() => Bulking("25"));
            //Thread t26 = new Thread(() => Bulking("26"));
            //Thread t27 = new Thread(() => Bulking("27"));
            //Thread t28 = new Thread(() => Bulking("28"));
            //Thread t29 = new Thread(() => Bulking("29"));
            //Thread t30 = new Thread(() => Bulking("30"));
            //Thread t31 = new Thread(() => Bulking("31"));
            //Thread t32 = new Thread(() => Bulking("32"));
            //Thread t33 = new Thread(() => Bulking("33"));
            //Thread t34 = new Thread(() => Bulking("34"));
            //Thread t35 = new Thread(() => Bulking("35"));
            //Thread t36 = new Thread(() => Bulking("36"));
            //Thread t37 = new Thread(() => Bulking("37"));
            //Thread t38 = new Thread(() => Bulking("38"));
            //Thread t39 = new Thread(() => Bulking("39"));
            //Thread t40 = new Thread(() => Bulking("40"));
            //Thread t41 = new Thread(() => Bulking("41"));
            //Thread t42 = new Thread(() => Bulking("42"));
            //Thread t43 = new Thread(() => Bulking("43"));
            //Thread t44 = new Thread(() => Bulking("44"));
            //Thread t45 = new Thread(() => Bulking("45"));
            //Thread t46 = new Thread(() => Bulking("46"));
            //Thread t47 = new Thread(() => Bulking("47"));
            //Thread t48 = new Thread(() => Bulking("48"));
            //Thread t49 = new Thread(() => Bulking("49"));
            
            #endregion

            #region Threads Priority
            t0.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Highest;
            t4.Priority = ThreadPriority.Highest;
            t5.Priority = ThreadPriority.Highest;
            //t6.Priority = ThreadPriority.Highest;
            //t7.Priority = ThreadPriority.Highest;
            //t8.Priority = ThreadPriority.Highest;
            //t9.Priority = ThreadPriority.Highest;
            //t10.Priority = ThreadPriority.Highest;
            //t11.Priority = ThreadPriority.Highest;
            //t12.Priority = ThreadPriority.Highest;
            //t13.Priority = ThreadPriority.Highest;
            //t14.Priority = ThreadPriority.Highest;
            //t15.Priority = ThreadPriority.Highest;
            //t16.Priority = ThreadPriority.Highest;
            //t17.Priority = ThreadPriority.Highest;
            //t18.Priority = ThreadPriority.Highest;
            //t19.Priority = ThreadPriority.Highest;
            //t20.Priority = ThreadPriority.Highest;
            //t21.Priority = ThreadPriority.Highest;
            //t22.Priority = ThreadPriority.Highest;
            //t23.Priority = ThreadPriority.Highest;
            //t24.Priority = ThreadPriority.Highest;
            //t25.Priority = ThreadPriority.Highest;
            //t26.Priority = ThreadPriority.Highest;
            //t27.Priority = ThreadPriority.Highest;
            //t28.Priority = ThreadPriority.Highest;
            //t29.Priority = ThreadPriority.Highest;
            //t30.Priority = ThreadPriority.Highest;
            //t31.Priority = ThreadPriority.Highest;
            //t32.Priority = ThreadPriority.Highest;
            //t33.Priority = ThreadPriority.Highest;
            //t34.Priority = ThreadPriority.Highest;
            //t35.Priority = ThreadPriority.Highest;
            //t36.Priority = ThreadPriority.Highest;
            //t37.Priority = ThreadPriority.Highest;
            //t38.Priority = ThreadPriority.Highest;
            //t39.Priority = ThreadPriority.Highest;
            //t40.Priority = ThreadPriority.Highest;
            //t41.Priority = ThreadPriority.Highest;
            //t42.Priority = ThreadPriority.Highest;
            //t43.Priority = ThreadPriority.Highest;
            //t44.Priority = ThreadPriority.Highest;
            //t45.Priority = ThreadPriority.Highest;
            //t46.Priority = ThreadPriority.Highest;
            //t47.Priority = ThreadPriority.Highest;
            //t48.Priority = ThreadPriority.Highest;
            //t49.Priority = ThreadPriority.Highest;
            #endregion

            #region Threads Strat
            t0.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            //t6.Start();
            //t7.Start();
            //t8.Start();
            //t9.Start();
            //t10.Start();
            //t11.Start();
            //t12.Start();
            //t13.Start();
            //t14.Start();
            //t15.Start();
            //t16.Start();
            //t17.Start();
            //t18.Start();
            //t19.Start();
            //t20.Start();
            //t21.Start();
            //t22.Start();
            //t23.Start();
            //t24.Start();
            //t25.Start();
            //t26.Start();
            //t27.Start();
            //t28.Start();
            //t29.Start();
            //t30.Start();
            //t31.Start();
            //t32.Start();
            //t33.Start();
            //t34.Start();
            //t35.Start();
            //t36.Start();
            //t37.Start();
            //t38.Start();
            //t39.Start();
            //t40.Start();
            //t41.Start();
            //t42.Start();
            //t43.Start();
            //t44.Start();
            //t45.Start();
            //t46.Start();
            //t47.Start();
            //t48.Start();
            //t49.Start();
            #endregion

            #region Threads Join
            t0.Join();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            //t6.Join();
            //t7.Join();
            //t8.Join();
            //t9.Join();
            //t10.Join();
            //t11.Join();
            //t12.Join();
            //t13.Join();
            //t14.Join();
            //t15.Join();
            //t16.Join();
            //t17.Join();
            //t18.Join();
            //t19.Join();
            //t20.Join();
            //t21.Join();
            //t22.Join();
            //t23.Join();
            //t24.Join();
            //t25.Join();
            //t26.Join();
            //t27.Join();
            //t28.Join();
            //t29.Join();
            //t30.Join();
            //t31.Join();
            //t32.Join();
            //t33.Join();
            //t34.Join();
            //t35.Join();
            //t36.Join();
            //t37.Join();
            //t38.Join();
            //t39.Join();
            //t40.Join();
            //t41.Join();
            //t42.Join();
            //t43.Join();
            //t44.Join();
            //t45.Join();
            //t46.Join();
            //t47.Join();
            //t48.Join();
            //t49.Join();
            #endregion

        }


        private async Task Bulking(string Thread_ID)
        {

            #region
            Stopwatch sw = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            for (int i = 0; i < 150; i++)
            {
                try
                {
                    sw.Reset();
                    sw.Start();

                    using (Generator gen = new Generator())
                    {
                        gen.gen_list();
                        using (var con = gen.Get_Connection())
                        {
                            while (locked)
                            {
                            }
                            locked = true;
                            con.Open();
                            using (SqlTransaction transaction = con.BeginTransaction())
                            {
                                using (SqlBulkCopy Bulk = new SqlBulkCopy(con, SqlBulkCopyOptions.Default, transaction))
                                {
                                    using (DataTable dt = new DataTable())
                                    {
                                        try
                                        {
                                            Bulk.DestinationTableName = "tbl_person";

                                            await Bulk.WriteToServerAsync((DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(gen.people), (typeof(DataTable))));

                                            transaction.Commit();
                                        }
                                        catch (Exception ex)
                                        {
                                            var x = ex.Message;
                                            transaction.Rollback();
                                        }
                                    }
                                }
                            }
                            con.Close();
                            locked = false;
                        }
                        gen.logger(Thread_ID + i,_context.TblPeople.Where(x => x.Id != null).Count(), sw.ElapsedMilliseconds.ToString(), sw2.ElapsedMilliseconds.ToString());
                    }
                    sw.Stop();
                }
                catch (Exception)
                {
                    continue;
                }
            }

            sw.Stop();

            #endregion

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
