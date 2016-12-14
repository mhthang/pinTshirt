using Autofac;
using PinTshirt.Data.EntityFramework;
using PinTshirt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinTshirt.Data.Repositories
{
    public class SKRepositoryAutoFacModule : Module
    {
        private readonly string _connStr;

        public SKRepositoryAutoFacModule(string connString)
        {
            this._connStr = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new PSDataContext(_connStr)).As<IPSDataContext>().InstancePerRequest();

            //#region Application
            //builder.RegisterType<CountryRepository>().As<ICountryRepository>();
            //builder.RegisterType<TimezoneRepository>().As<ITimezoneRepository>();

            //builder.RegisterType<ProfileRepository>().As<IProfileRepository>();

            //builder.RegisterType<ClassGroupRepository>().As<IClassGroupRepository>();
            //builder.RegisterType<ClassRoomRepository>().As<IClassRoomRepository>();
            //builder.RegisterType<ClassCourseRepository>().As<IClassCourseRepository>();
            //builder.RegisterType<DivisionRepository>().As<IDivisionRepository>();
            //builder.RegisterType<OrganizationRepository>().As<IOrganizationRepository>();
            //builder.RegisterType<SemesterRepository>().As<ISemesterRepository>();
            //builder.RegisterType<SubjectGroupRepository>().As<ISubjectGroupRepository>();
            //builder.RegisterType<SubjectRepository>().As<ISubjectRepository>();
            //builder.RegisterType<BuildingRepository>().As<IBuildingRepository>();

            //builder.RegisterType<TimetableRepository>().As<ITimetableRepository>();
            //builder.RegisterType<ClassTimetableRepository>().As<IClassTimetableRepository>();

            //builder.RegisterType<CourseSectionRepository>().As<ICourseSectionRepository>();
            //builder.RegisterType<SchedulingTableRepository>().As<ISchedulingTableRepository>();

            //builder.RegisterType<CourseRepository>().As<ICourseRepository>();
            //builder.RegisterType<TrainingProgramRepository>().As<ITrainingProgramRepository>();

            //builder.RegisterType<SchedulingTableRepository>().As<ISchedulingTableRepository>();

            //#endregion

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
