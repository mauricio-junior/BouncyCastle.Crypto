using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHash.sourceText
{
    public static class DataBase
    {
        /// <summary>
        /// Método.
        /// </summary>
        /// <returns></returns>
        public static string meuTexto()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"USE [BEPiD]
GO
/****** Object:  Table [dbo].[AlunoResponsavelTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlunoResponsavelTDB](
	[IdAlunoResponsavel] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[IdResponsavel] [bigint] NOT NULL,
 CONSTRAINT [PK_AlunoResponsavelTDB] PRIMARY KEY CLUSTERED 
(
	[IdAlunoResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlunoStatusTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlunoStatusTDB](
	[IdStatus] [bigint] NOT NULL,
	[NomeStatus] [nvarchar](50) NOT NULL,
	[DescricaoStatus] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_AlunoStatusTDB] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlunoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlunoTDB](
	[IdAluno] [bigint] IDENTITY(1,1) NOT NULL,
	[IdInstituicao] [bigint] NOT NULL,
	[IdEvento] [bigint] NOT NULL,
	[NomeAluno] [nvarchar](400) NOT NULL,
	[SerieAluno] [nvarchar](50) NOT NULL,
	[TurnoAluno] [nvarchar](10) NOT NULL,
	[SexoAluno] [char](1) NOT NULL,
	[DataNascimentoAluno] [date] NOT NULL,
	[RendaFamiliaAluno] [money] NOT NULL,
	[PlanoSaudeAluno] [char](1) NOT NULL,
	[PlanoDentalAluno] [char](1) NOT NULL,
	[IdStatusAluno] [bigint] NOT NULL,
 CONSTRAINT [PK_AlunoTDB] PRIMARY KEY CLUSTERED 
(
	[IdAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConsideracaoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsideracaoTDB](
	[IdConsideracao] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[DescricaoConsideracao] [nvarchar](700) NOT NULL,
	[DataConsideracao] [date] NOT NULL,
 CONSTRAINT [PK_AlunoTDBConsideracoes] PRIMARY KEY CLUSTERED 
(
	[IdConsideracao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoTDB](
	[IdDocumento] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[NomeDocumento] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_DocumentoTDB] PRIMARY KEY CLUSTERED 
(
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoStatusTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoStatusTDB](
	[IdStatus] [bigint] NOT NULL,
	[NomeStatus] [nvarchar](50) NOT NULL,
	[DescricaoStatus] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_EventoStatusTDB] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoTDB](
	[IdEvento] [bigint] IDENTITY(1,1) NOT NULL,
	[IdInstituicao] [bigint] NOT NULL,
	[NomeEvento] [nvarchar](50) NOT NULL,
	[DataInicioEvento] [date] NOT NULL,
	[DataFimEvento] [date] NOT NULL,
	[IdStatusEvento] [bigint] NOT NULL,
	[LocalEvento] [nvarchar](200) NULL,
	[ObservacaoEvento] [nvarchar](300) NULL,
 CONSTRAINT [PK_EventoTDB] PRIMARY KEY CLUSTERED 
(
	[IdEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoUsuarioTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoUsuarioTDB](
	[IdEventoUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[IdEvento] [bigint] NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
 CONSTRAINT [PK_EventoUsuarioTDB] PRIMARY KEY CLUSTERED 
(
	[IdEventoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FotoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FotoTDB](
	[IdFoto] [bigint] IDENTITY(1,1) NOT NULL,
	[IdTipoFoto] [bigint] NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[NomeFoto] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_FotoTDB] PRIMARY KEY CLUSTERED 
(
	[IdFoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IHCTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IHCTDB](
	[IdIHC] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[ControleDoenca] [char](3) NOT NULL,
	[ControleLesao] [nvarchar](10) NOT NULL,
	[TratamentoEspecializado] [nvarchar](10) NOT NULL,
	[NecessidadeEspecialista] [nvarchar](10) NOT NULL,
	[PacienteComDor] [char](3) NOT NULL,
	[descricaoEspecializado] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_IHCTDB] PRIMARY KEY CLUSTERED 
(
	[IdIHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstituicaoStatusTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstituicaoStatusTDB](
	[IdStatus] [bigint] NOT NULL,
	[NomeStatus] [nvarchar](50) NOT NULL,
	[DescricaoStatus] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_InstituicaoStatusTDB] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstituicaoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstituicaoTDB](
	[IdInstituicao] [bigint] IDENTITY(1,1) NOT NULL,
	[NomeInstituicao] [nvarchar](300) NOT NULL,
	[EnderecoInstituicao] [nvarchar](400) NOT NULL,
	[CidadeInstituicao] [nvarchar](50) NOT NULL,
	[EstadoInstituicao] [nvarchar](2) NOT NULL,
	[CEPInstituicao] [nvarchar](20) NOT NULL,
	[IdStatusInstituicao] [bigint] NOT NULL,
	[TelefoneInstituicao] [varchar](30) NOT NULL,
 CONSTRAINT [PK_InstituicaoTDB] PRIMARY KEY CLUSTERED 
(
	[IdInstituicao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstituicaoUsuarioTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstituicaoUsuarioTDB](
	[IdInstituicaoUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[IdInstituicao] [bigint] NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
 CONSTRAINT [PK_InstituicaoUsuarioTDB] PRIMARY KEY CLUSTERED 
(
	[IdInstituicaoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PercepcaoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PercepcaoTDB](
	[IdPercepcao] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[TemCarie] [char](3) NOT NULL,
	[VergonhaDosDentes] [nvarchar](30) NOT NULL,
	[FoiAoDentista] [char](3) NOT NULL,
	[Onde] [nvarchar](30) NULL,
 CONSTRAINT [PK_PercepcaoTDB] PRIMARY KEY CLUSTERED 
(
	[IdPercepcao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerguntasSocioEconomicasTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerguntasSocioEconomicasTDB](
	[IdPerguntas] [bigint] IDENTITY(1,1) NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[CarroProprio] [int] NOT NULL,
	[CasaComodo] [int] NOT NULL,
	[QuemTrabalha] [varchar](15) NOT NULL,
 CONSTRAINT [PK_PerguntasSocioEconomicasTDB] PRIMARY KEY CLUSTERED 
(
	[IdPerguntas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponsavelTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponsavelTDB](
	[IdResponsavel] [bigint] IDENTITY(1,1) NOT NULL,
	[NomeResponsavel] [nvarchar](300) NOT NULL,
	[CPFResponsavel] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_ResponsavelTDB] PRIMARY KEY CLUSTERED 
(
	[IdResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SincronismoStatusTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SincronismoStatusTDB](
	[IdStatus] [bigint] NOT NULL,
	[NomeStatus] [nvarchar](50) NOT NULL,
	[DescricaoStatus] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_SincronismoStatusTDB] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SincronismoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SincronismoTDB](
	[IdSincronismo] [bigint] NOT NULL,
	[IdAluno] [bigint] NOT NULL,
	[IdUsuario] [bigint] NOT NULL,
	[IdStatusSincronismo] [bigint] NOT NULL,
	[DataSincronismo] [date] NOT NULL,
	[ComandoSincronismo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_SincronismoTDB] PRIMARY KEY CLUSTERED 
(
	[IdSincronismo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoFotoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoFotoTDB](
	[IdTipoFoto] [bigint] IDENTITY(1,1) NOT NULL,
	[DescricaoTipoFoto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoFotoTDB] PRIMARY KEY CLUSTERED 
(
	[IdTipoFoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioStatusTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioStatusTDB](
	[IdStatus] [bigint] NOT NULL,
	[NomeStatus] [nvarchar](50) NOT NULL,
	[DescricaoStatus] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_UsuarioStatusTDB] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioTDB](
	[IdUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [nvarchar](300) NOT NULL,
	[EmailUsuario] [nvarchar](400) NOT NULL,
	[SenhaUsuario] [nvarchar](500) NOT NULL,
	[IdStatusUsuario] [bigint] NOT NULL,
	[IdUsuarioTipo] [bigint] NULL,
	[CROUsuario] [nvarchar](50) NULL,
	[ProfissaoUsuario] [nvarchar](50) NULL,
	[TelefoneUsuario] [nvarchar](30) NULL,
	[IdUsuarioCadastrou] [bigint] NULL,
 CONSTRAINT [PK_UsuarioTDB] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioTipoTDB]    Script Date: 11/20/17 11:40:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioTipoTDB](
	[IdUsuarioTipo] [bigint] NOT NULL,
	[NomeTipo] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_UsuarioTipoTDB] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlunoResponsavelTDB]  WITH CHECK ADD  CONSTRAINT [FK_AlunoResponsavelTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[AlunoResponsavelTDB] CHECK CONSTRAINT [FK_AlunoResponsavelTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[AlunoResponsavelTDB]  WITH CHECK ADD  CONSTRAINT [FK_AlunoResponsavelTDB_ResponsavelTDB] FOREIGN KEY([IdResponsavel])
REFERENCES [dbo].[ResponsavelTDB] ([IdResponsavel])
GO
ALTER TABLE [dbo].[AlunoResponsavelTDB] CHECK CONSTRAINT [FK_AlunoResponsavelTDB_ResponsavelTDB]
GO
ALTER TABLE [dbo].[AlunoTDB]  WITH CHECK ADD  CONSTRAINT [FK_AlunoTDB_AlunoStatusTDB] FOREIGN KEY([IdStatusAluno])
REFERENCES [dbo].[AlunoStatusTDB] ([IdStatus])
GO
ALTER TABLE [dbo].[AlunoTDB] CHECK CONSTRAINT [FK_AlunoTDB_AlunoStatusTDB]
GO
ALTER TABLE [dbo].[AlunoTDB]  WITH CHECK ADD  CONSTRAINT [FK_AlunoTDB_EventoTDB] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[EventoTDB] ([IdEvento])
GO
ALTER TABLE [dbo].[AlunoTDB] CHECK CONSTRAINT [FK_AlunoTDB_EventoTDB]
GO
ALTER TABLE [dbo].[AlunoTDB]  WITH CHECK ADD  CONSTRAINT [FK_AlunoTDB_InstituicaoTDB] FOREIGN KEY([IdInstituicao])
REFERENCES [dbo].[InstituicaoTDB] ([IdInstituicao])
GO
ALTER TABLE [dbo].[AlunoTDB] CHECK CONSTRAINT [FK_AlunoTDB_InstituicaoTDB]
GO
ALTER TABLE [dbo].[ConsideracaoTDB]  WITH CHECK ADD  CONSTRAINT [FK_ConsideracaoTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[ConsideracaoTDB] CHECK CONSTRAINT [FK_ConsideracaoTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[DocumentoTDB]  WITH CHECK ADD  CONSTRAINT [FK_DocumentoTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[DocumentoTDB] CHECK CONSTRAINT [FK_DocumentoTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[EventoTDB]  WITH CHECK ADD  CONSTRAINT [FK_EventoTDB_EventoStatusTDB] FOREIGN KEY([IdStatusEvento])
REFERENCES [dbo].[EventoStatusTDB] ([IdStatus])
GO
ALTER TABLE [dbo].[EventoTDB] CHECK CONSTRAINT [FK_EventoTDB_EventoStatusTDB]
GO
ALTER TABLE [dbo].[EventoUsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_EventoUsuarioTDB_EventoTDB] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[EventoTDB] ([IdEvento])
GO
ALTER TABLE [dbo].[EventoUsuarioTDB] CHECK CONSTRAINT [FK_EventoUsuarioTDB_EventoTDB]
GO
ALTER TABLE [dbo].[EventoUsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_EventoUsuarioTDB_UsuarioTDB] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[UsuarioTDB] ([IdUsuario])
GO
ALTER TABLE [dbo].[EventoUsuarioTDB] CHECK CONSTRAINT [FK_EventoUsuarioTDB_UsuarioTDB]
GO
ALTER TABLE [dbo].[FotoTDB]  WITH CHECK ADD  CONSTRAINT [FK_FotoTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[FotoTDB] CHECK CONSTRAINT [FK_FotoTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[FotoTDB]  WITH CHECK ADD  CONSTRAINT [FK_FotoTDB_TipoFotoTDB] FOREIGN KEY([IdTipoFoto])
REFERENCES [dbo].[TipoFotoTDB] ([IdTipoFoto])
GO
ALTER TABLE [dbo].[FotoTDB] CHECK CONSTRAINT [FK_FotoTDB_TipoFotoTDB]
GO
ALTER TABLE [dbo].[IHCTDB]  WITH CHECK ADD  CONSTRAINT [FK_IHCTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[IHCTDB] CHECK CONSTRAINT [FK_IHCTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[InstituicaoTDB]  WITH CHECK ADD  CONSTRAINT [FK_InstituicaoTDB_InstituicaoStatusTDB] FOREIGN KEY([IdStatusInstituicao])
REFERENCES [dbo].[InstituicaoStatusTDB] ([IdStatus])
GO
ALTER TABLE [dbo].[InstituicaoTDB] CHECK CONSTRAINT [FK_InstituicaoTDB_InstituicaoStatusTDB]
GO
ALTER TABLE [dbo].[InstituicaoUsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_InstituicaoUsuarioTDB_InstituicaoTDB] FOREIGN KEY([IdInstituicao])
REFERENCES [dbo].[InstituicaoTDB] ([IdInstituicao])
GO
ALTER TABLE [dbo].[InstituicaoUsuarioTDB] CHECK CONSTRAINT [FK_InstituicaoUsuarioTDB_InstituicaoTDB]
GO
ALTER TABLE [dbo].[InstituicaoUsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_InstituicaoUsuarioTDB_UsuarioTDB] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[UsuarioTDB] ([IdUsuario])
GO
ALTER TABLE [dbo].[InstituicaoUsuarioTDB] CHECK CONSTRAINT [FK_InstituicaoUsuarioTDB_UsuarioTDB]
GO
ALTER TABLE [dbo].[PercepcaoTDB]  WITH CHECK ADD  CONSTRAINT [FK_PercepcaoTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[PercepcaoTDB] CHECK CONSTRAINT [FK_PercepcaoTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[PerguntasSocioEconomicasTDB]  WITH CHECK ADD  CONSTRAINT [FK_PerguntasSocioEconomicasTDB_AlunoTDB] FOREIGN KEY([IdAluno])
REFERENCES [dbo].[AlunoTDB] ([IdAluno])
GO
ALTER TABLE [dbo].[PerguntasSocioEconomicasTDB] CHECK CONSTRAINT [FK_PerguntasSocioEconomicasTDB_AlunoTDB]
GO
ALTER TABLE [dbo].[SincronismoTDB]  WITH CHECK ADD  CONSTRAINT [FK_SincronismoTDB_SincronismoStatusTDB] FOREIGN KEY([IdStatusSincronismo])
REFERENCES [dbo].[SincronismoStatusTDB] ([IdStatus])
GO
ALTER TABLE [dbo].[SincronismoTDB] CHECK CONSTRAINT [FK_SincronismoTDB_SincronismoStatusTDB]
GO
ALTER TABLE [dbo].[UsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioTDB_UsuarioStatusTDB] FOREIGN KEY([IdStatusUsuario])
REFERENCES [dbo].[UsuarioStatusTDB] ([IdStatus])
GO
ALTER TABLE [dbo].[UsuarioTDB] CHECK CONSTRAINT [FK_UsuarioTDB_UsuarioStatusTDB]
GO
ALTER TABLE [dbo].[UsuarioTDB]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioTDB_UsuarioTipoTDB] FOREIGN KEY([IdUsuarioTipo])
REFERENCES [dbo].[UsuarioTipoTDB] ([IdUsuarioTipo])
GO
ALTER TABLE [dbo].[UsuarioTDB] CHECK CONSTRAINT [FK_UsuarioTDB_UsuarioTipoTDB]
GO
");

            return str.ToString();
        }
    }
}
