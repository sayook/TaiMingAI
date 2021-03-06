﻿using AutoMapper;
using ConsoleTest.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TaiMingAi.WebApi.Model;
using TaiMingAI.Caches;
using TaiMingAI.Manager.Model;
using TaiMingAI.Tools;
using TaiMingAI.WebApi;
using TaiMingAI.WebApi.BLL;
using TaiMingAI.WebApi.Models;
using TaiMingAI.DataHelper;
using System.Threading;

namespace ConsoleTest
{
    class Program
    {
        static string PrintTitle(Book book)
        {
            var m = string.Format("《{0}》——{1}", book.Title, book.Author);
            return m;
        }
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("西游记", "吴承恩", 19.95m, true);
            bookDB.AddBook("水浒传", "施耐庵", 39.95m, true);
            bookDB.AddBook("三国演义", "罗贯中", 129.95m, false);
            bookDB.AddBook("金瓶梅", "兰陵笑笑生", 12.00m, true);
        }
        public delegate string helloDel(string s);
        delegate void HeaterWaterDel();
        static void Main(string[] args)
        {
            #region api接口 签名验证测试
            //var appId = "1002";
            //var key = "D9B0C2E7-B25E-43AC-B69B-FAF7AA4DAADB";
            //var timestamp = TimestampHelper.GetNowTimestampOfJs();
            //var sign = appId + timestamp + key;
            //sign = sign.Sha256();

            //Dictionary<string, string> headers = new Dictionary<string, string> {
            //    {"appId",appId },
            //    {"time",timestamp.ToString() },
            //    {"sign",sign }
            //};

            //var url = "http://api.taiming.com/api/Task/Create";
            //var request = new CreateTaskRequest
            //{
            //    TaksName = "first task",
            //    UserName = "admin",
            //    Phone = 18888888888
            //};
            //var s = WebApiHelper.PostResponseJson(url, JsonHelper.ToJson(request), headers);
            //SongBLL songBll = new SongBLL();
            //var result = songBll.BaiduTingSearch("双节棍");
            //Console.Write(s);
            #endregion

            #region 工厂模式
            //ICreateDataBaseFactory factory = new CreateOracleFactory();
            //IUserServer iu = factory.GetUserServer();
            //IProductServer ip = factory.GetProductServer();
            //UserInfo user = iu.GetUserInfoById(1);
            //iu.InsertUser(new UserInfo { name = "悟空" });
            //ip.GetProductInfo(2);

            //DataAccess dataAccess = new DataAccess();
            //IUserServer us = dataAccess.GetServer();
            //us.GetUserInfoById(1122);

            //IOperateFactory f = new SubOperateFactory();
            //IOperate o = f.GetOperate();
            //o.GetResult(3, 4);
            #endregion

            #region 委托与事件
            //var tom = new Cat("Tom");
            //var jerry = new Mouse("jerry");
            //var jack = new Mouse("jack");
            //tom.CatShout += new CatShoutEventHandle(jerry.Run);
            //tom.CatShout += new CatShoutEventHandle(jack.Run);
            //tom.Shout();

            //BookDB bookDB = new BookDB();
            //AddBooks(bookDB);
            //Console.WriteLine("平价书的名称：");
            //bookDB.ProcessPaperbackBooks(PrintTitle);
            //PriceTotaller priceTotaller = new PriceTotaller();
            //bookDB.ProcessPaperbackBooks(priceTotaller.AddBookTotal);
            //Console.WriteLine("平价书的均价: ${0:#.##}", priceTotaller.AveragePrice());
            //helloDel s = (string st) => st + "hello";
            //priceTotaller.hello("李瓶儿", PrintTitle);
            //Console.WriteLine(s("无敌"));
            //Console.WriteLine("我想洗澡...");
            //Heater heater = new Heater(45);
            //heater.HeatWater();
            //HeaterWaterDel heaterWaterDel = heater.HeatWater;
            //IAsyncResult asyncResult = heaterWaterDel.BeginInvoke(null, null);
            //Console.WriteLine("我先去看会儿电视...");
            //int i = 0;
            //while (!asyncResult.IsCompleted)
            //{
            //    Console.Write("{0}.. ", (i++).ToString());
            //    if (asyncResult.IsCompleted)
            //    {
            //        Console.WriteLine("水烧好了，去洗澡");
            //    }
            //}
            //heaterWaterDel.EndInvoke(asyncResult);
            #endregion

            #region 装饰模式
            //ConcreteComponent cc = new ConcreteComponent();
            //Decorator cda = new ConcreteDecoratorA();
            //Decorator cdb = new ConcreteDecoratorB();
            //cda.SetComponent(cc);
            //cdb.SetComponent(cda);
            //cdb.Operation();
            //Console.WriteLine("*********************************");
            //Hero jugg = new JUGG("剑圣");
            //SkillDecorator q = new QSkill(jugg, "剑刃风暴");
            //SkillDecorator w = new WSkill(q, "治疗守卫");
            //w.LearnSkill();
            #endregion

            #region 代理模式
            //Proxy proxy = new Proxy();
            //proxy.Request();

            //Beauty mm = new Beauty("紫霞仙子");
            //Proxy proxy = new Proxy(mm);
            //proxy.GiveChocolate();
            //proxy.GiveFlowers();
            #endregion

            #region 策略模式
            //Context context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();
            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();
            //context = new Context(new ConcreteStrategyC());
            //context.ContextInterface();
            //string[] flags = { "1", "2", "3" };
            //Console.WriteLine("*************************************");
            //Console.WriteLine("请选择所处阶段，获取相应策略");
            //Console.WriteLine("【1】：相见时...");
            //Console.WriteLine("【2】：相识时...");
            //Console.WriteLine("【3】：相知时...");
            //Console.WriteLine("*************************************");
            //bool isRun = true;
            //do
            //{
            //    var flag = Console.ReadLine();
            //    if (flags.Contains(flag))
            //    {
            //        BigThink bigThink = new BigThink(flag);
            //        bigThink.GetStrategy();
            //        Console.WriteLine(".............................");
            //        Console.WriteLine("按上述指令之外按键退出...");
            //    }
            //    else
            //    {
            //        isRun = false;
            //    }

            //} while (isRun);
            #endregion

            #region 建造者模式   
            //Director director = new Director();
            //ConcreteBuilder1 builder1 = new ConcreteBuilder1();
            //director.Construct(builder1);
            //Product p1 = builder1.GetResult();
            //p1.Show();

            //ConcreteBuilder2 builder2 = new ConcreteBuilder2();
            //director.Construct(builder2);
            //Product p2 = builder2.GetResult();
            //p2.Show();

            //Chef chef = new Chef();
            //BuildClassicalMeal buildClassical = new BuildClassicalMeal();
            //chef.GiveMeal(buildClassical);
            //Meal classicalMeal = buildClassical.GetMeal();
            //classicalMeal.Show();

            //BuildLuxuriousMeal buildLuxurious = new BuildLuxuriousMeal();
            //chef.GiveMeal(buildLuxurious);
            //Meal luxuriousMeal = buildLuxurious.GetMeal();
            //luxuriousMeal.Show();
            //DelBuilder db = buildClassical.BuildePartA;
            //db += buildClassical.BuildePartB;
            //db.Invoke();
            //Meal classicalMeal = buildClassical.GetMeal();
            //classicalMeal.Show();
            #endregion

            #region AutoMapper
            //TaiMingAI.Manager.Model.AutoMapper.Configuration.Configure();
            //RoleDto role = new RoleDto
            //{
            //    Name = "ss",
            //    Id = 9
            //};
            //var list = new List<RoleDto> { role };
            //Console.WriteLine("Role:{0}", JsonHelper.ToJson(list));
            //var dto = Mapper.Map<List<RoleDto>, List<Role>>(list);
            //var d = Mapper.Map<Role>(role);

            //AdministratorDto ad = new AdministratorDto
            //{
            //    NickName = "dd",
            //    Mobile = "12345"
            //};
            //var add = ad.MapTo<Administrator>();
            //Navbar navbar = new Navbar { Id = 22, href = "baidu" };
            //Dictionary<string, string> dictionary = new Dictionary<string, string>
            //{
            //    { "Id","ParentId"},
            //    { "href","icon"}
            //};
            //var navbarDat = navbar.MapTo<NavbarDto>(dictionary);
            //Console.WriteLine("add:{0}", JsonHelper.ToJson(d));
            #endregion

            #region 线程 Thread
            //Console.WriteLine("程序已启动...");
            //Thread t1 = new Thread(Thread1);
            //t1.Start();

            //var t2 = new Thread(Therad2)
            //{
            //    IsBackground = true
            //};
            //t2.Start("阿三");
            //Console.WriteLine("线程池已启动...");

            //WaitCallback workItem = state => Console.WriteLine(state + "-当前线程ID:" + Thread.CurrentThread.ManagedThreadId);
            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(workItem, "线程池【" + i + "】");
            //}
            #endregion

            #region 依赖倒置、控制反转、依赖注入


            #endregion

            #region Parallel
            Test t = new Test();
            t.Parallel_For();
            //ParallelTest parallelTest = new ParallelTest();
            //parallelTest.Parallel_Invoke();
            //parallelTest.Parallel_For();
            //parallelTest.Parallel_ForEach();
            #endregion
            Console.ReadKey();
        }

        public static void Test(string key)
        {
            var flg = CacheHelper.DoRedisString.Incr(key + "Incr");
            LogHelper.InfoLogFormat("key:{0},访问次数：{1}", key, flg);
        }

        private static void Thread1()
        {
            Thread.Sleep(1500);
            Console.WriteLine("主线程...");
        }

        private static void Therad2(object str)
        {
            Thread.Sleep(5000);
            Console.WriteLine("后台线程:" + str);
        }
    }
    class PersonSection : ConfigurationSection
    {
        [ConfigurationProperty("age", IsRequired = false, DefaultValue = 0)]
        public int Age
        {
            get { return (int)base["age"]; }
            set { base["age"] = value; }
        }

        [ConfigurationProperty("name", IsRequired = false, DefaultValue = "")]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }
    }
}
