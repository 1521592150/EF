using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using DAO;
using IBLL;
using IBLL;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
namespace IocContainer
{
    public class IocCreate
    {
        //public static IAdminDAO CreateAdminDAO()
        //{
        //    UnityContainer ioc = new UnityContainer();
        //    ioc.RegisterType<IAdminDAO, AdminDAO>();
        //    return ioc.Resolve<IAdminDAO>();
        //}
        //public static IAdminBLL CreateAdminBLL()
        //{
        //    UnityContainer ioc = new UnityContainer();
        //    //把Unity文件转换为文件对象
        //    ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
        //    ef.ExeConfigFilename = "Unity.config";
        //    //把文件对象转换为配置对象
        //    Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
        //    //读取Unity节点(业务逻辑层的块)
        //    UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
        //    //容器里加载业务逻辑层的配置块
        //    ioc.LoadConfiguration(cs, "containerTwo");
        //    //ioc.RegisterType<IUserDAO, UserDAO>();
        //    return ioc.Resolve<IAdminBLL>("AdminBLL");

        //}
    }
}
