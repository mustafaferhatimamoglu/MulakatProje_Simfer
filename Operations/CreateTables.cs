using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatProje_Simfer.Operations
{
    internal class CreateTables
    {
        public static void Create_Person()
        {
            try
            {
                Database.SQL_query("DROP TABLE TBL_PERSON");
            }
            catch (Exception)
            {
                //No Handling required
            }
            Database.SQL_query(@"
SET ANSI_NULLS ON
--GO

SET QUOTED_IDENTIFIER ON
--GO

CREATE TABLE [dbo].[TBL_Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Gen] [int] NOT NULL,
	[FID_PM] [int] NULL,
	[FID_PF] [int] NULL,
	[BirthYear] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Person] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--GO

ALTER TABLE [dbo].[TBL_Person]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Person_TBL_Person] FOREIGN KEY([FID_PF])
REFERENCES [dbo].[TBL_Person] ([ID])
--GO

ALTER TABLE [dbo].[TBL_Person] CHECK CONSTRAINT [FK_TBL_Person_TBL_Person]
--GO

ALTER TABLE [dbo].[TBL_Person]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Person_TBL_Person1] FOREIGN KEY([FID_PM])
REFERENCES [dbo].[TBL_Person] ([ID])
--GO

ALTER TABLE [dbo].[TBL_Person] CHECK CONSTRAINT [FK_TBL_Person_TBL_Person1]
--GO
");
        }
    }
}
