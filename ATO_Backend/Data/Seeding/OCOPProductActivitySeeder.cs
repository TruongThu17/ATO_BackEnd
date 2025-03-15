using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class OCOPProductActivitySeeder
    {
        private readonly ModelBuilder modelBuilder;

        public OCOPProductActivitySeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //Seed OCOPProductActivity
            modelBuilder.Entity<OCOPProductActivity>().HasData(
                new OCOPProductActivity()
                {
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546")
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("C58BB9C8-AD26-40BC-A5D5-F8D09049F7AA"),
                },

                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("4335F0E8-9EA3-48A7-B0CF-5185FF675DDE"),
                },
                //
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("798A3B9B-F7C9-4E84-A563-39421E6585F4"),
                },
                //
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("F51AAAF7-9BB1-4A69-A634-0AB1162FD9C1"),
                },
                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("69006CFE-5233-4B8E-B181-D81A485873E3"),
                },
                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("98E14DA8-40DD-4E50-BD9B-EB74112F6625"),
                },
                //
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("60F2DCDD-7257-4CE4-8ABD-FC01E4EAE546"),
                    ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("5ACD4E26-7EC5-4633-8FE7-A0D97692EF7A"),
                    ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("7DF9849B-DDD8-457C-BABF-303356349173"),
                    ProductId = Guid.Parse("639E1CFC-1266-4B30-9022-3927C1721AFD"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("694FCE72-18EB-44D0-97E5-FD2CA2840C96"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("6723A17D-AE68-478E-9667-D2E62CB0AEBA"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("06F562CF-B39E-428F-921E-8FC94826505E"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("26DC3636-9823-4900-AD4D-7AB5F408CBBA"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("C0FE9C22-A634-48F1-9847-279C95F9C483"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                },
                new OCOPProductActivity()
                {
                    ActivityId = Guid.Parse("CDA718C5-68F0-49ED-A33A-3B564182031E"),
                    ProductId = Guid.Parse("65966980-988A-4D92-89B4-2B74425FE3F3"),
                }
            );
        }
    }
}
