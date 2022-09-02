using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using StudentAffairDAL;
using StudentAffairDSL;
using StudentAffairDSL.DSLInterfaces;
using StudentAffairRepo;
using StudentAffairRepo.Interfaces;

namespace StudentAffairAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(option => option.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StudentAffairAPI", Version = "v1" });
            });
            services.AddCors();

            //services.AddSingleton<Core.Common.Logging.ILogger, Core.Common.Logging.Logger>();

            #region RegisterRepositories
            services.AddTransient<IStudentRepo, StudentRepo>();
            services.AddTransient<ISubjectRepo, SubjectRepo>();
            services.AddTransient<IClassRepo, ClassRepo>();
            #endregion

            #region RegisterDataServices
            services.AddTransient<IStudentDSL, StudenttDSL>();
            services.AddTransient<ISubjectDSL, SubjectDSL>();
            services.AddTransient<IClassDSL, ClassDSL>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentAffairAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
