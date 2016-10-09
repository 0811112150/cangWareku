using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Warehouse.DomainModel;
using Warehouse.Common;
using Warehouse.DAL;
using Ninject.Parameters;
using System.Data.Entity;

namespace Warehouse.BLL
{
    public class RepositoryIoc
    {
        readonly static string _constructorArgumentName = "context";
        private static IKernel _ninjectKernel = new StandardKernel();
        static RepositoryIoc()
        {
            _ninjectKernel.Bind<IRepository<WarehouseM>>().To<GenericRepository<WarehouseM>>();
            _ninjectKernel.Bind<IRepository<TwoDimensioncode>>().To<GenericRepository<TwoDimensioncode>>();
            _ninjectKernel.Bind<IRepository<SpeedChangeBoxType>>().To<GenericRepository<SpeedChangeBoxType>>();
            _ninjectKernel.Bind<IRepository<RemovalWarehouseRecord>>().To<GenericRepository<RemovalWarehouseRecord>>();
            _ninjectKernel.Bind<IRepository<PutInWarehouseRecord>>().To<GenericRepository<PutInWarehouseRecord>>();
            _ninjectKernel.Bind<IRepository<RemovalWarehouseOrder>>().To<GenericRepository<RemovalWarehouseOrder>>();
            _ninjectKernel.Bind<IRepository<UsersInfo>>().To<GenericRepository<UsersInfo>>();
            _ninjectKernel.Bind<IRepository<Department>>().To<GenericRepository<Department>>();
			_ninjectKernel.Bind<IRepository<Alarm>>().To<GenericRepository<Alarm>>();

        }

		public static IRepository<Alarm> GetAlarmRepository(WarehouseContext db)
		{
			return _ninjectKernel.Get<IRepository<Alarm>>(new ConstructorArgument(_constructorArgumentName, db));
		}

        public static IRepository<Department> GetDepartmentRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<Department>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<UsersInfo> GetUsersInfoRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<UsersInfo>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<RemovalWarehouseOrder> GetRemovalWarehouseOrderRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<RemovalWarehouseOrder>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<WarehouseM> GetWarehouseMRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<WarehouseM>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<TwoDimensioncode> GetTwoDimensioncodeRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<TwoDimensioncode>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<SpeedChangeBoxType> GetSpeedChangeBoxTypeRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<SpeedChangeBoxType>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<RemovalWarehouseRecord> GetRemovalWarehourseRecordRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<RemovalWarehouseRecord>>(new ConstructorArgument(_constructorArgumentName, db));
        }

        public static IRepository<PutInWarehouseRecord> GetPutInWarehouseRecordRepository(WarehouseContext db)
        {
            return _ninjectKernel.Get<IRepository<PutInWarehouseRecord>>(new ConstructorArgument(_constructorArgumentName, db));
        }

    }
}
