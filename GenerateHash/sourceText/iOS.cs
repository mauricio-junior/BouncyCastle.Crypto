using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHash.sourceText
{
    public static class iOS
    {
        ///
        public static string meuTexto()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"// !$*UTF8*$!
{
	archiveVersion = 1;
	classes = {
	};
	objectVersion = 46;
	objects = {

/* Begin PBXBuildFile section */
		1203658824757BD8984ACF28 /* Pods_ProjetoTDBUITests.framework in Frameworks */ = {isa = PBXBuildFile; fileRef = D349E8C9968EDA9D6441E638 /* Pods_ProjetoTDBUITests.framework */; };
		4B16BF5E1E4EA014A6EB615C /* Pods_ProjetoTDBTests.framework in Frameworks */ = {isa = PBXBuildFile; fileRef = 15C09401CE504E77CAEB0B0B /* Pods_ProjetoTDBTests.framework */; };
		5B2952F71F3CE37600449E7D /* GlobalCommom.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B2952F61F3CE37600449E7D /* GlobalCommom.swift */; };
		5B3D10561F3255330099E2CB /* PerfilTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3D10551F3255330099E2CB /* PerfilTableViewController.swift */; };
		5B3D10581F3267760099E2CB /* Evento.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5B3D10571F3267760099E2CB /* Evento.storyboard */; };
		5B3F5AF81F3B7DF300905BBB /* PerguntasSocioEconomicasTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5AF71F3B7DF300905BBB /* PerguntasSocioEconomicasTDBModel.swift */; };
		5B3F5AFA1F3B7EE500905BBB /* PerguntasSocioEconomicasTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5AF91F3B7EE500905BBB /* PerguntasSocioEconomicasTDBBL.swift */; };
		5B3F5AFC1F3B7F1E00905BBB /* PerguntasSocioEconomicasTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5AFB1F3B7F1E00905BBB /* PerguntasSocioEconomicasTDBDAL.swift */; };
		5B3F5AFE1F3B916D00905BBB /* ConsideracoesTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5AFD1F3B916D00905BBB /* ConsideracoesTableViewController.swift */; };
		5B3F5B021F3C8BA400905BBB /* PercepcoesTDBTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5B011F3C8BA400905BBB /* PercepcoesTDBTableViewController.swift */; };
		5B3F5B041F3C91B000905BBB /* PercepcoesTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5B031F3C91B000905BBB /* PercepcoesTDBDAL.swift */; };
		5B3F5B061F3C91CB00905BBB /* PercepcoesTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5B051F3C91CB00905BBB /* PercepcoesTDBModel.swift */; };
		5B3F5B081F3C91DB00905BBB /* PercepcoesTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B3F5B071F3C91DB00905BBB /* PercepcoesTDBBL.swift */; };
		5B515A1B1F38F25600A5BBBD /* FormatarData.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B515A1A1F38F25600A5BBBD /* FormatarData.swift */; };
		5B515A1D1F3A387200A5BBBD /* PerguntasSocioEconomicas.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5B515A1C1F3A387200A5BBBD /* PerguntasSocioEconomicas.storyboard */; };
		5B515A1F1F3A3B7B00A5BBBD /* PerguntasSocioEconomicasTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B515A1E1F3A3B7B00A5BBBD /* PerguntasSocioEconomicasTableViewController.swift */; };
		5B579D721F3E36B50020ABCA /* btn_perguntas_socioeconomicos.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D6F1F3E36B50020ABCA /* btn_perguntas_socioeconomicos.png */; };
		5B579D731F3E36B50020ABCA /* btn_perguntas_socioeconomicos@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D701F3E36B50020ABCA /* btn_perguntas_socioeconomicos@2x.png */; };
		5B579D741F3E36B50020ABCA /* btn_perguntas_socioeconomicos@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D711F3E36B50020ABCA /* btn_perguntas_socioeconomicos@3x.png */; };
		5B579D851F3E38770020ABCA /* instituicoes_fill.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D751F3E38770020ABCA /* instituicoes_fill.png */; };
		5B579D861F3E38770020ABCA /* instituicoes_fill@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D761F3E38770020ABCA /* instituicoes_fill@2x.png */; };
		5B579D871F3E38770020ABCA /* instituicoes_fill@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D771F3E38770020ABCA /* instituicoes_fill@3x.png */; };
		5B579D881F3E38770020ABCA /* instituicoes_outline.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D781F3E38770020ABCA /* instituicoes_outline.png */; };
		5B579D891F3E38770020ABCA /* perfil_fill.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D791F3E38770020ABCA /* perfil_fill.png */; };
		5B579D8A1F3E38770020ABCA /* perfil_fill@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7A1F3E38770020ABCA /* perfil_fill@2x.png */; };
		5B579D8B1F3E38770020ABCA /* perfil_fill@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7B1F3E38770020ABCA /* perfil_fill@3x.png */; };
		5B579D8C1F3E38770020ABCA /* perfil_outline.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7C1F3E38770020ABCA /* perfil_outline.png */; };
		5B579D8D1F3E38770020ABCA /* perfil_outline@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7D1F3E38770020ABCA /* perfil_outline@2x.png */; };
		5B579D8E1F3E38770020ABCA /* perfil_outline@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7E1F3E38770020ABCA /* perfil_outline@3x.png */; };
		5B579D8F1F3E38770020ABCA /* sync_fill.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D7F1F3E38770020ABCA /* sync_fill.png */; };
		5B579D901F3E38770020ABCA /* sync_fill@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D801F3E38770020ABCA /* sync_fill@2x.png */; };
		5B579D911F3E38770020ABCA /* sync_fill@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D811F3E38770020ABCA /* sync_fill@3x.png */; };
		5B579D921F3E38770020ABCA /* sync_outline.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D821F3E38770020ABCA /* sync_outline.png */; };
		5B579D931F3E38770020ABCA /* sync_outline@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D831F3E38770020ABCA /* sync_outline@2x.png */; };
		5B579D941F3E38770020ABCA /* sync_outline@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D841F3E38770020ABCA /* sync_outline@3x.png */; };
		5B579D961F3E3B490020ABCA /* SearchBackground.png in Resources */ = {isa = PBXBuildFile; fileRef = 5B579D951F3E3B490020ABCA /* SearchBackground.png */; };
		5B71021D1F5ED2CD00E0DD68 /* PerfilAlterarSenha.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5B71021C1F5ED2CD00E0DD68 /* PerfilAlterarSenha.storyboard */; };
		5B71021F1F5ED32000E0DD68 /* PerfilAlterarSenhaTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B71021E1F5ED32000E0DD68 /* PerfilAlterarSenhaTableViewController.swift */; };
		5B9C16DF1F7D6D4E0068B1F4 /* FieldText.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B9C16DE1F7D6D4E0068B1F4 /* FieldText.swift */; };
		5B9C16E11F7D79CB0068B1F4 /* MainTabBarViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5B9C16E01F7D79CB0068B1F4 /* MainTabBarViewController.swift */; };
		5BA27EA31F31520D0036BA93 /* AlertaTela.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BA27EA21F31520D0036BA93 /* AlertaTela.swift */; };
		5BB5E9561F30F9BE0098BDD0 /* AppDelegate.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9551F30F9BE0098BDD0 /* AppDelegate.swift */; };
		5BB5E95B1F30F9BE0098BDD0 /* Main.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E9591F30F9BE0098BDD0 /* Main.storyboard */; };
		5BB5E95D1F30F9BE0098BDD0 /* Assets.xcassets in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E95C1F30F9BE0098BDD0 /* Assets.xcassets */; };
		5BB5E9601F30F9BE0098BDD0 /* LaunchScreen.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E95E1F30F9BE0098BDD0 /* LaunchScreen.storyboard */; };
		5BB5E96B1F30F9BF0098BDD0 /* ProjetoTDBTests.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E96A1F30F9BF0098BDD0 /* ProjetoTDBTests.swift */; };
		5BB5E9761F30F9BF0098BDD0 /* ProjetoTDBUITests.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9751F30F9BF0098BDD0 /* ProjetoTDBUITests.swift */; };
		5BB5E9871F30FA0A0098BDD0 /* Instituicao.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E9841F30FA0A0098BDD0 /* Instituicao.storyboard */; };
		5BB5E9881F30FA0A0098BDD0 /* Perfil.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E9851F30FA0A0098BDD0 /* Perfil.storyboard */; };
		5BB5E9891F30FA0A0098BDD0 /* Sincronizacao.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = 5BB5E9861F30FA0A0098BDD0 /* Sincronizacao.storyboard */; };
		5BB5E9941F30FA120098BDD0 /* AlunoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E98B1F30FA120098BDD0 /* AlunoTDBModel.swift */; };
		5BB5E9951F30FA120098BDD0 /* ConsideracaoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E98C1F30FA120098BDD0 /* ConsideracaoTDBModel.swift */; };
		5BB5E9961F30FA120098BDD0 /* DocumentoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E98D1F30FA120098BDD0 /* DocumentoTDBModel.swift */; };
		5BB5E9971F30FA120098BDD0 /* EventoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E98E1F30FA120098BDD0 /* EventoTDBModel.swift */; };
		5BB5E9981F30FA120098BDD0 /* FotoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E98F1F30FA120098BDD0 /* FotoTDBModel.swift */; };
		5BB5E9991F30FA120098BDD0 /* IHCTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9901F30FA120098BDD0 /* IHCTDBModel.swift */; };
		5BB5E99A1F30FA120098BDD0 /* InstituicaoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9911F30FA120098BDD0 /* InstituicaoTDBModel.swift */; };
		5BB5E99B1F30FA120098BDD0 /* TipoFotoTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9921F30FA120098BDD0 /* TipoFotoTDBModel.swift */; };
		5BB5E99C1F30FA120098BDD0 /* UsuarioTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9931F30FA120098BDD0 /* UsuarioTDBModel.swift */; };
		5BB5E9A71F30FA1F0098BDD0 /* AlunoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E99E1F30FA1F0098BDD0 /* AlunoTDBDAL.swift */; };
		5BB5E9A81F30FA1F0098BDD0 /* ConsideracaoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E99F1F30FA1F0098BDD0 /* ConsideracaoTDBDAL.swift */; };
		5BB5E9A91F30FA1F0098BDD0 /* DocumentoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A01F30FA1F0098BDD0 /* DocumentoTDBDAL.swift */; };
		5BB5E9AA1F30FA1F0098BDD0 /* EventoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A11F30FA1F0098BDD0 /* EventoTDBDAL.swift */; };
		5BB5E9AB1F30FA1F0098BDD0 /* FotoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A21F30FA1F0098BDD0 /* FotoTDBDAL.swift */; };
		5BB5E9AC1F30FA1F0098BDD0 /* IHCTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A31F30FA1F0098BDD0 /* IHCTDBDAL.swift */; };
		5BB5E9AD1F30FA1F0098BDD0 /* InstituicaoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A41F30FA1F0098BDD0 /* InstituicaoTDBDAL.swift */; };
		5BB5E9AE1F30FA1F0098BDD0 /* TipoFotoTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A51F30FA1F0098BDD0 /* TipoFotoTDBDAL.swift */; };
		5BB5E9AF1F30FA1F0098BDD0 /* UsuarioTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9A61F30FA1F0098BDD0 /* UsuarioTDBDAL.swift */; };
		5BB5E9B31F30FA250098BDD0 /* IntituicaoTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9B11F30FA250098BDD0 /* IntituicaoTDBViewController.swift */; };
		5BB5E9B41F30FA250098BDD0 /* LoginTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9B21F30FA250098BDD0 /* LoginTDBViewController.swift */; };
		5BB5E9B81F30FA2A0098BDD0 /* Constantes.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9B61F30FA2A0098BDD0 /* Constantes.swift */; };
		5BB5E9B91F30FA2A0098BDD0 /* LoadingView.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9B71F30FA2A0098BDD0 /* LoadingView.swift */; };
		5BB5E9C41F30FA2F0098BDD0 /* AlunoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9BB1F30FA2F0098BDD0 /* AlunoTDBBL.swift */; };
		5BB5E9C51F30FA2F0098BDD0 /* ConsideracaoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9BC1F30FA2F0098BDD0 /* ConsideracaoTDBBL.swift */; };
		5BB5E9C61F30FA2F0098BDD0 /* DocumentoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9BD1F30FA2F0098BDD0 /* DocumentoTDBBL.swift */; };
		5BB5E9C71F30FA2F0098BDD0 /* EventoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9BE1F30FA2F0098BDD0 /* EventoTDBBL.swift */; };
		5BB5E9C81F30FA2F0098BDD0 /* FotoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9BF1F30FA2F0098BDD0 /* FotoTDBBL.swift */; };
		5BB5E9C91F30FA2F0098BDD0 /* IHCTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9C01F30FA2F0098BDD0 /* IHCTDBBL.swift */; };
		5BB5E9CA1F30FA2F0098BDD0 /* InstituicaoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9C11F30FA2F0098BDD0 /* InstituicaoTDBBL.swift */; };
		5BB5E9CB1F30FA2F0098BDD0 /* TipoFotoTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9C21F30FA2F0098BDD0 /* TipoFotoTDBBL.swift */; };
		5BB5E9CC1F30FA2F0098BDD0 /* UsuarioTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB5E9C31F30FA2F0098BDD0 /* UsuarioTDBBL.swift */; };
		5BB613321F33683A00D49E72 /* EventoTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BB613311F33683A00D49E72 /* EventoTableViewCell.swift */; };
		5BB6133F1F339F2A00D49E72 /* 01 iPhone 7@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613341F339F2A00D49E72 /* 01 iPhone 7@2x.png */; };
		5BB613401F339F2A00D49E72 /* 02 iPhone 7 Plus@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613351F339F2A00D49E72 /* 02 iPhone 7 Plus@2x.png */; };
		5BB613411F339F2A00D49E72 /* 03 login@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613361F339F2A00D49E72 /* 03 login@2x.png */; };
		5BB613421F339F2A00D49E72 /* 04 instituicoes@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613371F339F2A00D49E72 /* 04 instituicoes@2x.png */; };
		5BB613431F339F2A00D49E72 /* 05 descricao instituicoes@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613381F339F2A00D49E72 /* 05 descricao instituicoes@2x.png */; };
		5BB613441F339F2A00D49E72 /* 06 descricao instituicoes alerta@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB613391F339F2A00D49E72 /* 06 descricao instituicoes alerta@2x.png */; };
		5BB613451F339F2A00D49E72 /* 07 descricao Paciente - IHC@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB6133A1F339F2A00D49E72 /* 07 descricao Paciente - IHC@2x.png */; };
		5BB613461F339F2A00D49E72 /* 08 descricao Paciente - Percepcoes@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB6133B1F339F2A00D49E72 /* 08 descricao Paciente - Percepcoes@2x.png */; };
		5BB613471F339F2A00D49E72 /* 09 descricao Paciente - Fotos@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB6133C1F339F2A00D49E72 /* 09 descricao Paciente - Fotos@2x.png */; };
		5BB613481F339F2A00D49E72 /* 10 descricao Paciente - Considerações@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB6133D1F339F2A00D49E72 /* 10 descricao Paciente - Considerações@2x.png */; };
		5BB613491F339F2A00D49E72 /* 11 sincronização@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BB6133E1F339F2A00D49E72 /* 11 sincronização@2x.png */; };
		5BD64A091F82CCBA0035288C /* VerificarTabelas.swift in Sources */ = {isa = PBXBuildFile; fileRef = 5BD64A081F82CCBA0035288C /* VerificarTabelas.swift */; };
		5BFAAE2F1F30FFBE00584F5C /* login_TDB.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BFAAE2D1F30FFBE00584F5C /* login_TDB.png */; };
		5BFAAE321F310CE700584F5C /* slide1_1.png in Resources */ = {isa = PBXBuildFile; fileRef = 5BFAAE311F310CE700584F5C /* slide1_1.png */; };
		A53CB8921F3B3BF4000BE404 /* FotoTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = A53CB8911F3B3BF4000BE404 /* FotoTableViewCell.swift */; };
		A53CB8941F3B3D23000BE404 /* FotoViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = A53CB8931F3B3D23000BE404 /* FotoViewController.swift */; };
		A53CB89C1F3BA64A000BE404 /* IHCTDBTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = A53CB89B1F3BA64A000BE404 /* IHCTDBTableViewController.swift */; };
		A53CB89E1F3BA69C000BE404 /* dente.png in Resources */ = {isa = PBXBuildFile; fileRef = A53CB89D1F3BA69C000BE404 /* dente.png */; };
		A58DEC2D1F3DF4DF0039B90B /* FotoEditorViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = A58DEC2C1F3DF4DF0039B90B /* FotoEditorViewController.swift */; };
		A5A6E8781F55C0F1000535A0 /* FotoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = A5A6E8771F55C0F1000535A0 /* FotoDAO.swift */; };
		A5A6E87A1F560A5B000535A0 /* TipoFotoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = A5A6E8791F560A5B000535A0 /* TipoFotoDAO.swift */; };
		A5C3AF901F433CBF003F9A5B /* GoogleService-Info.plist in Resources */ = {isa = PBXBuildFile; fileRef = A5C3AF8F1F433CBF003F9A5B /* GoogleService-Info.plist */; };
		AC001E641F6B225200728E92 /* AuxiliaresCadastroTableTableViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E631F6B225200728E92 /* AuxiliaresCadastroTableTableViewController.swift */; };
		AC001E841F71971000728E92 /* InstituicaoUsuarioTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E831F71971000728E92 /* InstituicaoUsuarioTDBDAL.swift */; };
		AC001E861F71978A00728E92 /* EventoUsuarioTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E851F71978A00728E92 /* EventoUsuarioTDBDAL.swift */; };
		AC001E881F7197E600728E92 /* EventoUsuarioTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E871F7197E600728E92 /* EventoUsuarioTDBModel.swift */; };
		AC001E8A1F71985200728E92 /* InstituicaoUsuarioTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E891F71985200728E92 /* InstituicaoUsuarioTDBModel.swift */; };
		AC001E8C1F71990600728E92 /* EventoUsuarioTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E8B1F71990600728E92 /* EventoUsuarioTDBBL.swift */; };
		AC001E8E1F71992F00728E92 /* InstituicaoUsuarioTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC001E8D1F71992F00728E92 /* InstituicaoUsuarioTDBBL.swift */; };
		AC02A5A01F32908E0076FA5B /* InstituicaoTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC02A59F1F32908E0076FA5B /* InstituicaoTableViewCell.swift */; };
		AC02A5A21F3354F70076FA5B /* EventoTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC02A5A11F3354F70076FA5B /* EventoTDBViewController.swift */; };
		AC02A5A61F33B8350076FA5B /* Aluno.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5A51F33B8350076FA5B /* Aluno.storyboard */; };
		AC02A5A81F33BAB10076FA5B /* AlunoTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC02A5A71F33BAB10076FA5B /* AlunoTDBViewController.swift */; };
		AC02A5AC1F34EFFF0076FA5B /* AlunoTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC02A5AB1F34EFFF0076FA5B /* AlunoTableViewCell.swift */; };
		AC02A5AE1F389F6A0076FA5B /* AlunoDetalhe.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5AD1F389F6A0076FA5B /* AlunoDetalhe.storyboard */; };
		AC02A5B01F38A1F60076FA5B /* AlunoDetalheTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = AC02A5AF1F38A1F50076FA5B /* AlunoDetalheTDBViewController.swift */; };
		AC02A5B81F3A46AB0076FA5B /* IHC.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5B71F3A46AB0076FA5B /* IHC.storyboard */; };
		AC02A5BA1F3A46FD0076FA5B /* Percepcoes.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5B91F3A46FD0076FA5B /* Percepcoes.storyboard */; };
		AC02A5BC1F3A47160076FA5B /* Foto.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5BB1F3A47160076FA5B /* Foto.storyboard */; };
		AC02A5BE1F3A472E0076FA5B /* Consideracoes.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = AC02A5BD1F3A472E0076FA5B /* Consideracoes.storyboard */; };
		AC09DC3C1F448A020085F926 /* GoogleToolboxForMac.framework in Frameworks */ = {isa = PBXBuildFile; fileRef = AC09DC3B1F448A020085F926 /* GoogleToolboxForMac.framework */; };
		ACFCA5401F69A54600E88E03 /* ParticipantesViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA53F1F69A54600E88E03 /* ParticipantesViewController.swift */; };
		ACFCA5421F69A5A900E88E03 /* ParticipantesTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA5411F69A5A900E88E03 /* ParticipantesTableViewCell.swift */; };
		ACFCA5441F69C7F300E88E03 /* Auxiliares.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = ACFCA5431F69C7F300E88E03 /* Auxiliares.storyboard */; };
		ACFCA5461F69C81600E88E03 /* Participantes.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = ACFCA5451F69C81600E88E03 /* Participantes.storyboard */; };
		ACFCA54C1F69D3C600E88E03 /* AuxiliaresTDBDAL.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA54B1F69D3C600E88E03 /* AuxiliaresTDBDAL.swift */; };
		ACFCA54E1F69D42000E88E03 /* AuxiliaresTDBModel.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA54D1F69D42000E88E03 /* AuxiliaresTDBModel.swift */; };
		ACFCA5501F69D49000E88E03 /* AuxiliaresTDBBL.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA54F1F69D49000E88E03 /* AuxiliaresTDBBL.swift */; };
		ACFCA5521F69D50E00E88E03 /* AuxiliaresTDBViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA5511F69D50E00E88E03 /* AuxiliaresTDBViewController.swift */; };
		ACFCA5541F6AC98A00E88E03 /* AuxiliaresTableViewCell.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFCA5531F6AC98A00E88E03 /* AuxiliaresTableViewCell.swift */; };
		ACFDB0051F599A800030F23E /* UserOnboarding.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = ACFDB0041F599A800030F23E /* UserOnboarding.storyboard */; };
		ACFDB0071F599CB20030F23E /* PageViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = ACFDB0061F599CB20030F23E /* PageViewController.swift */; };
		C6065EBD1F69CC780097D3CA /* EventoTDBViewController+SearchServices.swift in Sources */ = {isa = PBXBuildFile; fileRef = C6065EBC1F69CC780097D3CA /* EventoTDBViewController+SearchServices.swift */; };
		C614507E1F4DBCE300994EC3 /* SincronizacaoViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = C614507D1F4DBCE300994EC3 /* SincronizacaoViewController.swift */; };
		C61450811F4F106900994EC3 /* login_TDB@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = C614507F1F4F106900994EC3 /* login_TDB@2x.png */; };
		C61450821F4F106900994EC3 /* login_TDB@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = C61450801F4F106900994EC3 /* login_TDB@3x.png */; };
		C61450841F4F93A600994EC3 /* AlertControllerHelper.swift in Sources */ = {isa = PBXBuildFile; fileRef = C61450831F4F93A600994EC3 /* AlertControllerHelper.swift */; };
		C61450861F4FA6DE00994EC3 /* SincronizacaoDetail.storyboard in Resources */ = {isa = PBXBuildFile; fileRef = C61450851F4FA6DE00994EC3 /* SincronizacaoDetail.storyboard */; };
		C61450881F4FAE4E00994EC3 /* SincronizacaoDetailViewController.swift in Sources */ = {isa = PBXBuildFile; fileRef = C61450871F4FAE4E00994EC3 /* SincronizacaoDetailViewController.swift */; };
		C624EC881F6AC5EB008A7369 /* AlunoTDBViewController+SearchServices.swift in Sources */ = {isa = PBXBuildFile; fileRef = C624EC871F6AC5EB008A7369 /* AlunoTDBViewController+SearchServices.swift */; };
		C624EC8D1F6ACC33008A7369 /* teamwork.png in Resources */ = {isa = PBXBuildFile; fileRef = C624EC8A1F6ACC33008A7369 /* teamwork.png */; };
		C624EC8E1F6ACC33008A7369 /* teamwork@2x.png in Resources */ = {isa = PBXBuildFile; fileRef = C624EC8B1F6ACC33008A7369 /* teamwork@2x.png */; };
		C624EC8F1F6ACC33008A7369 /* teamwork@3x.png in Resources */ = {isa = PBXBuildFile; fileRef = C624EC8C1F6ACC33008A7369 /* teamwork@3x.png */; };
		C66B3B4D1F7E70AA00EA2122 /* IntituicaoTDBViewController+EmptyDataSet.swift in Sources */ = {isa = PBXBuildFile; fileRef = C66B3B4C1F7E70AA00EA2122 /* IntituicaoTDBViewController+EmptyDataSet.swift */; };
		C66B3B541F7E726D00EA2122 /* UIScrollView+EmptyDataSet.m in Sources */ = {isa = PBXBuildFile; fileRef = C66B3B521F7E726C00EA2122 /* UIScrollView+EmptyDataSet.m */; };
		C66B3B561F7E761B00EA2122 /* EventoTDBViewController+EmptyDataSet.swift in Sources */ = {isa = PBXBuildFile; fileRef = C66B3B551F7E761B00EA2122 /* EventoTDBViewController+EmptyDataSet.swift */; };
		C66B3B581F7E764D00EA2122 /* SincronizacaoViewController+EmptyDataSet.swift in Sources */ = {isa = PBXBuildFile; fileRef = C66B3B571F7E764D00EA2122 /* SincronizacaoViewController+EmptyDataSet.swift */; };
		C66B3B5A1F7E76B700EA2122 /* AlunoTDBViewController+EmptyDataSet.swift in Sources */ = {isa = PBXBuildFile; fileRef = C66B3B591F7E76B700EA2122 /* AlunoTDBViewController+EmptyDataSet.swift */; };
		C66F3B831F59B8EA00D87F2A /* SincronizacaoViewController+CloudServices.swift in Sources */ = {isa = PBXBuildFile; fileRef = C66F3B821F59B8EA00D87F2A /* SincronizacaoViewController+CloudServices.swift */; };
		C674658A1F6C1A5000888331 /* InstituicaoTDBViewController+SearchServices.swift in Sources */ = {isa = PBXBuildFile; fileRef = C67465891F6C1A5000888331 /* InstituicaoTDBViewController+SearchServices.swift */; };
		C68ED3B21F50495100B48E9F /* DatabaseManager.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3B11F50495100B48E9F /* DatabaseManager.swift */; };
		C68ED3B51F504BA400B48E9F /* DatabaseSource.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3B41F504BA400B48E9F /* DatabaseSource.swift */; };
		C68ED3B71F52269700B48E9F /* Extensions.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3B61F52269700B48E9F /* Extensions.swift */; };
		C68ED3BA1F52355600B48E9F /* AlunoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3B91F52355600B48E9F /* AlunoDAO.swift */; };
		C68ED3BC1F52356100B48E9F /* ConsideracaoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3BB1F52356100B48E9F /* ConsideracaoDAO.swift */; };
		C68ED3BE1F52356E00B48E9F /* DocumentoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3BD1F52356E00B48E9F /* DocumentoDAO.swift */; };
		C68ED3C01F52357700B48E9F /* EventoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3BF1F52357700B48E9F /* EventoDAO.swift */; };
		C68ED3C21F52358800B48E9F /* IHCDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3C11F52358800B48E9F /* IHCDAO.swift */; };
		C68ED3C41F52359200B48E9F /* InstituicaoDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3C31F52359200B48E9F /* InstituicaoDAO.swift */; };
		C68ED3C61F52359E00B48E9F /* UsuarioDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3C51F52359E00B48E9F /* UsuarioDAO.swift */; };
		C68ED3C81F5235AB00B48E9F /* PerguntasSocioeconomicasDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3C71F5235AB00B48E9F /* PerguntasSocioeconomicasDAO.swift */; };
		C68ED3CA1F5235B300B48E9F /* PercepcoesDAO.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3C91F5235B300B48E9F /* PercepcoesDAO.swift */; };
		C68ED3D41F5240D900B48E9F /* ApplicationMode.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3D11F5240D900B48E9F /* ApplicationMode.swift */; };
		C68ED3D51F5240D900B48E9F /* ErrorAlertUtils.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3D21F5240D900B48E9F /* ErrorAlertUtils.swift */; };
		C68ED3D61F5240D900B48E9F /* TDBError.swift in Sources */ = {isa = PBXBuildFile; fileRef = C68ED3D31F5240D900B48E9F /* TDBError.swift */; };
		FE9C6F7FA12CB49D12B697C5 /* Pods_ProjetoTDB.framework in Frameworks */ = {isa = PBXBuildFile; fileRef = 4659AE80D00AE7BCFA416C1C /* Pods_ProjetoTDB.framework */; };
/* End PBXBuildFile section */

/* Begin PBXContainerItemProxy section */
		5BB5E9671F30F9BF0098BDD0 /* PBXContainerItemProxy */ = {
			isa = PBXContainerItemProxy;
			containerPortal = 5BB5E94A1F30F9BE0098BDD0 /* Project object */;
			proxyType = 1;
			remoteGlobalIDString = 5BB5E9511F30F9BE0098BDD0;
			remoteInfo = ProjetoTDB;
		};
		5BB5E9721F30F9BF0098BDD0 /* PBXContainerItemProxy */ = {
			isa = PBXContainerItemProxy;
			containerPortal = 5BB5E94A1F30F9BE0098BDD0 /* Project object */;
			proxyType = 1;
			remoteGlobalIDString = 5BB5E9511F30F9BE0098BDD0;
			remoteInfo = ProjetoTDB;
		};
/* End PBXContainerItemProxy section */

/* Begin PBXFileReference section */
		15C09401CE504E77CAEB0B0B /* Pods_ProjetoTDBTests.framework */ = {isa = PBXFileReference; explicitFileType = wrapper.framework; includeInIndex = 0; path = Pods_ProjetoTDBTests.framework; sourceTree = BUILT_PRODUCTS_DIR; };
		33F274DAE6B8BF51E012D5A0 /* Pods-ProjetoTDBTests.release.xcconfig */ = {isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods - ProjetoTDBTests.release.xcconfig'; path = 'Pods / Target Support Files / Pods - ProjetoTDBTests / Pods - ProjetoTDBTests.release.xcconfig'; sourceTree = ' < group > '; };

        4659AE80D00AE7BCFA416C1C /* Pods_ProjetoTDB.framework */ = { isa = PBXFileReference; explicitFileType = wrapper.framework; includeInIndex = 0; path = Pods_ProjetoTDB.framework; sourceTree = BUILT_PRODUCTS_DIR; };
            51C96B37795CE19A47BBEA9F /* Pods-ProjetoTDBUITests.release.xcconfig */ = { isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods-ProjetoTDBUITests.release.xcconfig'; path = 'Pods/Target Support Files/Pods-ProjetoTDBUITests/Pods-ProjetoTDBUITests.release.xcconfig'; sourceTree = '<group>'; };
            5B2952F61F3CE37600449E7D /* GlobalCommom.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = GlobalCommom.swift; sourceTree = '<group>'; };
            5B3D10551F3255330099E2CB /* PerfilTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerfilTableViewController.swift; sourceTree = '<group>'; };
            5B3D10571F3267760099E2CB /* Evento.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Evento.storyboard; sourceTree = '<group>'; };
            5B3F5AF71F3B7DF300905BBB /* PerguntasSocioEconomicasTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerguntasSocioEconomicasTDBModel.swift; sourceTree = '<group>'; };
            5B3F5AF91F3B7EE500905BBB /* PerguntasSocioEconomicasTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerguntasSocioEconomicasTDBBL.swift; sourceTree = '<group>'; };
            5B3F5AFB1F3B7F1E00905BBB /* PerguntasSocioEconomicasTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerguntasSocioEconomicasTDBDAL.swift; sourceTree = '<group>'; };
            5B3F5AFD1F3B916D00905BBB /* ConsideracoesTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ConsideracoesTableViewController.swift; sourceTree = '<group>'; };
            5B3F5B011F3C8BA400905BBB /* PercepcoesTDBTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PercepcoesTDBTableViewController.swift; sourceTree = '<group>'; };
            5B3F5B031F3C91B000905BBB /* PercepcoesTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PercepcoesTDBDAL.swift; sourceTree = '<group>'; };
            5B3F5B051F3C91CB00905BBB /* PercepcoesTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PercepcoesTDBModel.swift; sourceTree = '<group>'; };
            5B3F5B071F3C91DB00905BBB /* PercepcoesTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PercepcoesTDBBL.swift; sourceTree = '<group>'; };
            5B515A1A1F38F25600A5BBBD /* FormatarData.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FormatarData.swift; sourceTree = '<group>'; };
            5B515A1C1F3A387200A5BBBD /* PerguntasSocioEconomicas.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = PerguntasSocioEconomicas.storyboard; sourceTree = '<group>'; };
            5B515A1E1F3A3B7B00A5BBBD /* PerguntasSocioEconomicasTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerguntasSocioEconomicasTableViewController.swift; sourceTree = '<group>'; };
            5B579D6F1F3E36B50020ABCA /* btn_perguntas_socioeconomicos.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = btn_perguntas_socioeconomicos.png; sourceTree = '<group>'; };
            5B579D701F3E36B50020ABCA /* btn_perguntas_socioeconomicos@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'btn_perguntas_socioeconomicos@2x.png'; sourceTree = '<group>'; };
            5B579D711F3E36B50020ABCA /* btn_perguntas_socioeconomicos@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'btn_perguntas_socioeconomicos@3x.png'; sourceTree = '<group>'; };
            5B579D751F3E38770020ABCA /* instituicoes_fill.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = instituicoes_fill.png; sourceTree = '<group>'; };
            5B579D761F3E38770020ABCA /* instituicoes_fill@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'instituicoes_fill@2x.png'; sourceTree = '<group>'; };
            5B579D771F3E38770020ABCA /* instituicoes_fill@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'instituicoes_fill@3x.png'; sourceTree = '<group>'; };
            5B579D781F3E38770020ABCA /* instituicoes_outline.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = instituicoes_outline.png; sourceTree = '<group>'; };
            5B579D791F3E38770020ABCA /* perfil_fill.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = perfil_fill.png; sourceTree = '<group>'; };
            5B579D7A1F3E38770020ABCA /* perfil_fill@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'perfil_fill@2x.png'; sourceTree = '<group>'; };
            5B579D7B1F3E38770020ABCA /* perfil_fill@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'perfil_fill@3x.png'; sourceTree = '<group>'; };
            5B579D7C1F3E38770020ABCA /* perfil_outline.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = perfil_outline.png; sourceTree = '<group>'; };
            5B579D7D1F3E38770020ABCA /* perfil_outline@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'perfil_outline@2x.png'; sourceTree = '<group>'; };
            5B579D7E1F3E38770020ABCA /* perfil_outline@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'perfil_outline@3x.png'; sourceTree = '<group>'; };
            5B579D7F1F3E38770020ABCA /* sync_fill.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = sync_fill.png; sourceTree = '<group>'; };
            5B579D801F3E38770020ABCA /* sync_fill@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'sync_fill@2x.png'; sourceTree = '<group>'; };
            5B579D811F3E38770020ABCA /* sync_fill@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'sync_fill@3x.png'; sourceTree = '<group>'; };
            5B579D821F3E38770020ABCA /* sync_outline.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = sync_outline.png; sourceTree = '<group>'; };
            5B579D831F3E38770020ABCA /* sync_outline@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'sync_outline@2x.png'; sourceTree = '<group>'; };
            5B579D841F3E38770020ABCA /* sync_outline@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'sync_outline@3x.png'; sourceTree = '<group>'; };
            5B579D951F3E3B490020ABCA /* SearchBackground.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = SearchBackground.png; sourceTree = '<group>'; };
            5B71021C1F5ED2CD00E0DD68 /* PerfilAlterarSenha.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = PerfilAlterarSenha.storyboard; sourceTree = '<group>'; };
            5B71021E1F5ED32000E0DD68 /* PerfilAlterarSenhaTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerfilAlterarSenhaTableViewController.swift; sourceTree = '<group>'; };
            5B9C16DE1F7D6D4E0068B1F4 /* FieldText.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = FieldText.swift; sourceTree = '<group>'; };
            5B9C16E01F7D79CB0068B1F4 /* MainTabBarViewController.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = MainTabBarViewController.swift; sourceTree = '<group>'; };
            5BA27EA21F31520D0036BA93 /* AlertaTela.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlertaTela.swift; sourceTree = '<group>'; };
            5BB0604660E74FAC771A7C41 /* Pods-ProjetoTDB.release.xcconfig */ = { isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods-ProjetoTDB.release.xcconfig'; path = 'Pods/Target Support Files/Pods-ProjetoTDB/Pods-ProjetoTDB.release.xcconfig'; sourceTree = '<group>'; };
            5BB5E9521F30F9BE0098BDD0 /* ProjetoTDB.app */ = { isa = PBXFileReference; explicitFileType = wrapper.application; includeInIndex = 0; path = ProjetoTDB.app; sourceTree = BUILT_PRODUCTS_DIR; };
            5BB5E9551F30F9BE0098BDD0 /* AppDelegate.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = AppDelegate.swift; sourceTree = '<group>'; };
            5BB5E95A1F30F9BE0098BDD0 /* Base */ = { isa = PBXFileReference; lastKnownFileType = file.storyboard; name = Base; path = Base.lproj / Main.storyboard; sourceTree = '<group>'; };
            5BB5E95C1F30F9BE0098BDD0 /* Assets.xcassets */ = { isa = PBXFileReference; lastKnownFileType = folder.assetcatalog; path = Assets.xcassets; sourceTree = '<group>'; };
            5BB5E95F1F30F9BE0098BDD0 /* Base */ = { isa = PBXFileReference; lastKnownFileType = file.storyboard; name = Base; path = Base.lproj / LaunchScreen.storyboard; sourceTree = '<group>'; };
            5BB5E9611F30F9BE0098BDD0 /* Info.plist */ = { isa = PBXFileReference; lastKnownFileType = text.plist.xml; path = Info.plist; sourceTree = '<group>'; };
            5BB5E9661F30F9BF0098BDD0 /* ProjetoTDBTests.xctest */ = { isa = PBXFileReference; explicitFileType = wrapper.cfbundle; includeInIndex = 0; path = ProjetoTDBTests.xctest; sourceTree = BUILT_PRODUCTS_DIR; };
            5BB5E96A1F30F9BF0098BDD0 /* ProjetoTDBTests.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = ProjetoTDBTests.swift; sourceTree = '<group>'; };
            5BB5E96C1F30F9BF0098BDD0 /* Info.plist */ = { isa = PBXFileReference; lastKnownFileType = text.plist.xml; path = Info.plist; sourceTree = '<group>'; };
            5BB5E9711F30F9BF0098BDD0 /* ProjetoTDBUITests.xctest */ = { isa = PBXFileReference; explicitFileType = wrapper.cfbundle; includeInIndex = 0; path = ProjetoTDBUITests.xctest; sourceTree = BUILT_PRODUCTS_DIR; };
            5BB5E9751F30F9BF0098BDD0 /* ProjetoTDBUITests.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = ProjetoTDBUITests.swift; sourceTree = '<group>'; };
            5BB5E9771F30F9BF0098BDD0 /* Info.plist */ = { isa = PBXFileReference; lastKnownFileType = text.plist.xml; path = Info.plist; sourceTree = '<group>'; };
            5BB5E9841F30FA0A0098BDD0 /* Instituicao.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Instituicao.storyboard; sourceTree = '<group>'; };
            5BB5E9851F30FA0A0098BDD0 /* Perfil.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Perfil.storyboard; sourceTree = '<group>'; };
            5BB5E9861F30FA0A0098BDD0 /* Sincronizacao.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Sincronizacao.storyboard; sourceTree = '<group>'; };
            5BB5E98B1F30FA120098BDD0 /* AlunoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E98C1F30FA120098BDD0 /* ConsideracaoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ConsideracaoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E98D1F30FA120098BDD0 /* DocumentoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DocumentoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E98E1F30FA120098BDD0 /* EventoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E98F1F30FA120098BDD0 /* FotoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E9901F30FA120098BDD0 /* IHCTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IHCTDBModel.swift; sourceTree = '<group>'; };
            5BB5E9911F30FA120098BDD0 /* InstituicaoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E9921F30FA120098BDD0 /* TipoFotoTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = TipoFotoTDBModel.swift; sourceTree = '<group>'; };
            5BB5E9931F30FA120098BDD0 /* UsuarioTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = UsuarioTDBModel.swift; sourceTree = '<group>'; };
            5BB5E99E1F30FA1F0098BDD0 /* AlunoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E99F1F30FA1F0098BDD0 /* ConsideracaoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ConsideracaoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A01F30FA1F0098BDD0 /* DocumentoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DocumentoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A11F30FA1F0098BDD0 /* EventoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A21F30FA1F0098BDD0 /* FotoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A31F30FA1F0098BDD0 /* IHCTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IHCTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A41F30FA1F0098BDD0 /* InstituicaoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A51F30FA1F0098BDD0 /* TipoFotoTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = TipoFotoTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9A61F30FA1F0098BDD0 /* UsuarioTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = UsuarioTDBDAL.swift; sourceTree = '<group>'; };
            5BB5E9B11F30FA250098BDD0 /* IntituicaoTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IntituicaoTDBViewController.swift; sourceTree = '<group>'; };
            5BB5E9B21F30FA250098BDD0 /* LoginTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = LoginTDBViewController.swift; sourceTree = '<group>'; };
            5BB5E9B61F30FA2A0098BDD0 /* Constantes.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = Constantes.swift; sourceTree = '<group>'; };
            5BB5E9B71F30FA2A0098BDD0 /* LoadingView.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = LoadingView.swift; sourceTree = '<group>'; };
            5BB5E9BB1F30FA2F0098BDD0 /* AlunoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9BC1F30FA2F0098BDD0 /* ConsideracaoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ConsideracaoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9BD1F30FA2F0098BDD0 /* DocumentoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DocumentoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9BE1F30FA2F0098BDD0 /* EventoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9BF1F30FA2F0098BDD0 /* FotoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9C01F30FA2F0098BDD0 /* IHCTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IHCTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9C11F30FA2F0098BDD0 /* InstituicaoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9C21F30FA2F0098BDD0 /* TipoFotoTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = TipoFotoTDBBL.swift; sourceTree = '<group>'; };
            5BB5E9C31F30FA2F0098BDD0 /* UsuarioTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = UsuarioTDBBL.swift; sourceTree = '<group>'; };
            5BB613311F33683A00D49E72 /* EventoTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoTableViewCell.swift; sourceTree = '<group>'; };
            5BB613341F339F2A00D49E72 /* 01 iPhone 7@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '01 iPhone 7@2x.png'; sourceTree = '<group>'; };
            5BB613351F339F2A00D49E72 /* 02 iPhone 7 Plus@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '02 iPhone 7 Plus@2x.png'; sourceTree = '<group>'; };
            5BB613361F339F2A00D49E72 /* 03 login@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '03 login@2x.png'; sourceTree = '<group>'; };
            5BB613371F339F2A00D49E72 /* 04 instituicoes@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '04 instituicoes@2x.png'; sourceTree = '<group>'; };
            5BB613381F339F2A00D49E72 /* 05 descricao instituicoes@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '05 descricao instituicoes@2x.png'; sourceTree = '<group>'; };
            5BB613391F339F2A00D49E72 /* 06 descricao instituicoes alerta@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '06 descricao instituicoes alerta@2x.png'; sourceTree = '<group>'; };
            5BB6133A1F339F2A00D49E72 /* 07 descricao Paciente - IHC@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '07 descricao Paciente - IHC@2x.png'; sourceTree = '<group>'; };
            5BB6133B1F339F2A00D49E72 /* 08 descricao Paciente - Percepcoes@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '08 descricao Paciente - Percepcoes@2x.png'; sourceTree = '<group>'; };
            5BB6133C1F339F2A00D49E72 /* 09 descricao Paciente - Fotos@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '09 descricao Paciente - Fotos@2x.png'; sourceTree = '<group>'; };
            5BB6133D1F339F2A00D49E72 /* 10 descricao Paciente - Considerações@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '10 descricao Paciente - Considerações@2x.png'; sourceTree = '<group>'; };
            5BB6133E1F339F2A00D49E72 /* 11 sincronização@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = '11 sincronização@2x.png'; sourceTree = '<group>'; };
            5BD64A081F82CCBA0035288C /* VerificarTabelas.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = VerificarTabelas.swift; sourceTree = '<group>'; };
            5BFAAE2D1F30FFBE00584F5C /* login_TDB.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = login_TDB.png; sourceTree = '<group>'; };
            5BFAAE311F310CE700584F5C /* slide1_1.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = slide1_1.png; sourceTree = '<group>'; };
            783758CF29ADF5D71965397B /* Pods-ProjetoTDBTests.debug.xcconfig */ = { isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods-ProjetoTDBTests.debug.xcconfig'; path = 'Pods/Target Support Files/Pods-ProjetoTDBTests/Pods-ProjetoTDBTests.debug.xcconfig'; sourceTree = '<group>'; };
            90AD77D84E5E1F5E3EDB38DC /* Pods-ProjetoTDB.debug.xcconfig */ = { isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods-ProjetoTDB.debug.xcconfig'; path = 'Pods/Target Support Files/Pods-ProjetoTDB/Pods-ProjetoTDB.debug.xcconfig'; sourceTree = '<group>'; };
            A53CB8911F3B3BF4000BE404 /* FotoTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoTableViewCell.swift; sourceTree = '<group>'; };
            A53CB8931F3B3D23000BE404 /* FotoViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoViewController.swift; sourceTree = '<group>'; };
            A53CB89B1F3BA64A000BE404 /* IHCTDBTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IHCTDBTableViewController.swift; sourceTree = '<group>'; };
            A53CB89D1F3BA69C000BE404 /* dente.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = dente.png; sourceTree = '<group>'; };
            A58DEC2C1F3DF4DF0039B90B /* FotoEditorViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoEditorViewController.swift; sourceTree = '<group>'; };
            A5A6E8771F55C0F1000535A0 /* FotoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = FotoDAO.swift; sourceTree = '<group>'; };
            A5A6E8791F560A5B000535A0 /* TipoFotoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = TipoFotoDAO.swift; sourceTree = '<group>'; };
            A5C3AF8F1F433CBF003F9A5B /* GoogleService-Info.plist */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = text.plist.xml; path = 'GoogleService-Info.plist'; sourceTree = '<group>'; };
            AC001E631F6B225200728E92 /* AuxiliaresCadastroTableTableViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresCadastroTableTableViewController.swift; sourceTree = '<group>'; };
            AC001E831F71971000728E92 /* InstituicaoUsuarioTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoUsuarioTDBDAL.swift; sourceTree = '<group>'; };
            AC001E851F71978A00728E92 /* EventoUsuarioTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoUsuarioTDBDAL.swift; sourceTree = '<group>'; };
            AC001E871F7197E600728E92 /* EventoUsuarioTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoUsuarioTDBModel.swift; sourceTree = '<group>'; };
            AC001E891F71985200728E92 /* InstituicaoUsuarioTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoUsuarioTDBModel.swift; sourceTree = '<group>'; };
            AC001E8B1F71990600728E92 /* EventoUsuarioTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoUsuarioTDBBL.swift; sourceTree = '<group>'; };
            AC001E8D1F71992F00728E92 /* InstituicaoUsuarioTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoUsuarioTDBBL.swift; sourceTree = '<group>'; };
            AC02A59F1F32908E0076FA5B /* InstituicaoTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; name = InstituicaoTableViewCell.swift; path = ../ Controller / InstituicaoTableViewCell.swift; sourceTree = '<group>'; };
            AC02A5A11F3354F70076FA5B /* EventoTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoTDBViewController.swift; sourceTree = '<group>'; };
            AC02A5A51F33B8350076FA5B /* Aluno.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Aluno.storyboard; sourceTree = '<group>'; };
            AC02A5A71F33BAB10076FA5B /* AlunoTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoTDBViewController.swift; sourceTree = '<group>'; };
            AC02A5AB1F34EFFF0076FA5B /* AlunoTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoTableViewCell.swift; sourceTree = '<group>'; };
            AC02A5AD1F389F6A0076FA5B /* AlunoDetalhe.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = AlunoDetalhe.storyboard; sourceTree = '<group>'; };
            AC02A5AF1F38A1F50076FA5B /* AlunoDetalheTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoDetalheTDBViewController.swift; sourceTree = '<group>'; };
            AC02A5B71F3A46AB0076FA5B /* IHC.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = IHC.storyboard; sourceTree = '<group>'; };
            AC02A5B91F3A46FD0076FA5B /* Percepcoes.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Percepcoes.storyboard; sourceTree = '<group>'; };
            AC02A5BB1F3A47160076FA5B /* Foto.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Foto.storyboard; sourceTree = '<group>'; };
            AC02A5BD1F3A472E0076FA5B /* Consideracoes.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Consideracoes.storyboard; sourceTree = '<group>'; };
            AC09DC3B1F448A020085F926 /* GoogleToolboxForMac.framework */ = { isa = PBXFileReference; lastKnownFileType = wrapper.framework; name = GoogleToolboxForMac.framework; path = '../../Library/Developer/Xcode/DerivedData/ProjetoTDB-dqsqedtsqwiwpaczcjwfhoqyldps/Build/Products/Debug-iphonesimulator/GoogleToolboxForMac/GoogleToolboxForMac.framework'; sourceTree = '<group>'; };
            ACFCA53F1F69A54600E88E03 /* ParticipantesViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ParticipantesViewController.swift; sourceTree = '<group>'; };
            ACFCA5411F69A5A900E88E03 /* ParticipantesTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ParticipantesTableViewCell.swift; sourceTree = '<group>'; };
            ACFCA5431F69C7F300E88E03 /* Auxiliares.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Auxiliares.storyboard; sourceTree = '<group>'; };
            ACFCA5451F69C81600E88E03 /* Participantes.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = Participantes.storyboard; sourceTree = '<group>'; };
            ACFCA54B1F69D3C600E88E03 /* AuxiliaresTDBDAL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresTDBDAL.swift; sourceTree = '<group>'; };
            ACFCA54D1F69D42000E88E03 /* AuxiliaresTDBModel.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresTDBModel.swift; sourceTree = '<group>'; };
            ACFCA54F1F69D49000E88E03 /* AuxiliaresTDBBL.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresTDBBL.swift; sourceTree = '<group>'; };
            ACFCA5511F69D50E00E88E03 /* AuxiliaresTDBViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresTDBViewController.swift; sourceTree = '<group>'; };
            ACFCA5531F6AC98A00E88E03 /* AuxiliaresTableViewCell.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AuxiliaresTableViewCell.swift; sourceTree = '<group>'; };
            ACFDB0041F599A800030F23E /* UserOnboarding.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = UserOnboarding.storyboard; sourceTree = '<group>'; };
            ACFDB0061F599CB20030F23E /* PageViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PageViewController.swift; sourceTree = '<group>'; };
            C6065EBC1F69CC780097D3CA /* EventoTDBViewController+SearchServices.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = 'EventoTDBViewController+SearchServices.swift'; sourceTree = '<group>'; };
            C614507D1F4DBCE300994EC3 /* SincronizacaoViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = SincronizacaoViewController.swift; sourceTree = '<group>'; };
            C614507F1F4F106900994EC3 /* login_TDB@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'login_TDB@2x.png'; sourceTree = '<group>'; };
            C61450801F4F106900994EC3 /* login_TDB@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'login_TDB@3x.png'; sourceTree = '<group>'; };
            C61450831F4F93A600994EC3 /* AlertControllerHelper.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlertControllerHelper.swift; sourceTree = '<group>'; };
            C61450851F4FA6DE00994EC3 /* SincronizacaoDetail.storyboard */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = file.storyboard; path = SincronizacaoDetail.storyboard; sourceTree = '<group>'; };
            C61450871F4FAE4E00994EC3 /* SincronizacaoDetailViewController.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = SincronizacaoDetailViewController.swift; sourceTree = '<group>'; };
            C624EC871F6AC5EB008A7369 /* AlunoTDBViewController+SearchServices.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = 'AlunoTDBViewController+SearchServices.swift'; sourceTree = '<group>'; };
            C624EC8A1F6ACC33008A7369 /* teamwork.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = teamwork.png; sourceTree = '<group>'; };
            C624EC8B1F6ACC33008A7369 /* teamwork@2x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'teamwork@2x.png'; sourceTree = '<group>'; };
            C624EC8C1F6ACC33008A7369 /* teamwork@3x.png */ = { isa = PBXFileReference; lastKnownFileType = image.png; path = 'teamwork@3x.png'; sourceTree = '<group>'; };
            C66B3B4C1F7E70AA00EA2122 /* IntituicaoTDBViewController+EmptyDataSet.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = 'IntituicaoTDBViewController+EmptyDataSet.swift'; sourceTree = '<group>'; };
            C66B3B511F7E726C00EA2122 /* ProjetoTDB-Bridging-Header.h */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.c.h; path = 'ProjetoTDB-Bridging-Header.h'; sourceTree = '<group>'; };
            C66B3B521F7E726C00EA2122 /* UIScrollView+EmptyDataSet.m */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.c.objc; path = 'UIScrollView+EmptyDataSet.m'; sourceTree = '<group>'; };
            C66B3B531F7E726D00EA2122 /* UIScrollView+EmptyDataSet.h */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.c.h; path = 'UIScrollView+EmptyDataSet.h'; sourceTree = '<group>'; };
            C66B3B551F7E761B00EA2122 /* EventoTDBViewController+EmptyDataSet.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = 'EventoTDBViewController+EmptyDataSet.swift'; sourceTree = '<group>'; };
            C66B3B571F7E764D00EA2122 /* SincronizacaoViewController+EmptyDataSet.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = 'SincronizacaoViewController+EmptyDataSet.swift'; sourceTree = '<group>'; };
            C66B3B591F7E76B700EA2122 /* AlunoTDBViewController+EmptyDataSet.swift */ = { isa = PBXFileReference; lastKnownFileType = sourcecode.swift; path = 'AlunoTDBViewController+EmptyDataSet.swift'; sourceTree = '<group>'; };
            C66F3B821F59B8EA00D87F2A /* SincronizacaoViewController+CloudServices.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = 'SincronizacaoViewController+CloudServices.swift'; sourceTree = '<group>'; };
            C67465891F6C1A5000888331 /* InstituicaoTDBViewController+SearchServices.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = 'InstituicaoTDBViewController+SearchServices.swift'; sourceTree = '<group>'; };
            C68ED3B11F50495100B48E9F /* DatabaseManager.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DatabaseManager.swift; sourceTree = '<group>'; };
            C68ED3B41F504BA400B48E9F /* DatabaseSource.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DatabaseSource.swift; sourceTree = '<group>'; };
            C68ED3B61F52269700B48E9F /* Extensions.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = Extensions.swift; sourceTree = '<group>'; };
            C68ED3B91F52355600B48E9F /* AlunoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = AlunoDAO.swift; sourceTree = '<group>'; };
            C68ED3BB1F52356100B48E9F /* ConsideracaoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ConsideracaoDAO.swift; sourceTree = '<group>'; };
            C68ED3BD1F52356E00B48E9F /* DocumentoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = DocumentoDAO.swift; sourceTree = '<group>'; };
            C68ED3BF1F52357700B48E9F /* EventoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = EventoDAO.swift; sourceTree = '<group>'; };
            C68ED3C11F52358800B48E9F /* IHCDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = IHCDAO.swift; sourceTree = '<group>'; };
            C68ED3C31F52359200B48E9F /* InstituicaoDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = InstituicaoDAO.swift; sourceTree = '<group>'; };
            C68ED3C51F52359E00B48E9F /* UsuarioDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = UsuarioDAO.swift; sourceTree = '<group>'; };
            C68ED3C71F5235AB00B48E9F /* PerguntasSocioeconomicasDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PerguntasSocioeconomicasDAO.swift; sourceTree = '<group>'; };
            C68ED3C91F5235B300B48E9F /* PercepcoesDAO.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = PercepcoesDAO.swift; sourceTree = '<group>'; };
            C68ED3D11F5240D900B48E9F /* ApplicationMode.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ApplicationMode.swift; sourceTree = '<group>'; };
            C68ED3D21F5240D900B48E9F /* ErrorAlertUtils.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = ErrorAlertUtils.swift; sourceTree = '<group>'; };
            C68ED3D31F5240D900B48E9F /* TDBError.swift */ = { isa = PBXFileReference; fileEncoding = 4; lastKnownFileType = sourcecode.swift; path = TDBError.swift; sourceTree = '<group>'; };
            D349E8C9968EDA9D6441E638 /* Pods_ProjetoTDBUITests.framework */ = { isa = PBXFileReference; explicitFileType = wrapper.framework; includeInIndex = 0; path = Pods_ProjetoTDBUITests.framework; sourceTree = BUILT_PRODUCTS_DIR; };
            EC9518955A9836A53BE8F70D /* Pods-ProjetoTDBUITests.debug.xcconfig */ = { isa = PBXFileReference; includeInIndex = 1; lastKnownFileType = text.xcconfig; name = 'Pods-ProjetoTDBUITests.debug.xcconfig'; path = 'Pods/Target Support Files/Pods-ProjetoTDBUITests/Pods-ProjetoTDBUITests.debug.xcconfig'; sourceTree = '<group>'; };
            /* End PBXFileReference section */

            /* Begin PBXFrameworksBuildPhase section */
            5BB5E94F1F30F9BE0098BDD0 /* Frameworks */ = {
                isa = PBXFrameworksBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    AC09DC3C1F448A020085F926 /* GoogleToolboxForMac.framework in Frameworks */,
                    FE9C6F7FA12CB49D12B697C5 /* Pods_ProjetoTDB.framework in Frameworks */,
    
                );
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E9631F30F9BF0098BDD0 /* Frameworks */ = {
                isa = PBXFrameworksBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    4B16BF5E1E4EA014A6EB615C /* Pods_ProjetoTDBTests.framework in Frameworks */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E96E1F30F9BF0098BDD0 /* Frameworks */ = {
                isa = PBXFrameworksBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    1203658824757BD8984ACF28 /* Pods_ProjetoTDBUITests.framework in Frameworks */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            /* End PBXFrameworksBuildPhase section */

            /* Begin PBXGroup section */
            2877F6A988DF8023D2C937D0 /* Pods */ = {
                isa = PBXGroup;
                children = (
                    90AD77D84E5E1F5E3EDB38DC /* Pods-ProjetoTDB.debug.xcconfig */,
				5BB0604660E74FAC771A7C41 /* Pods-ProjetoTDB.release.xcconfig */,
				783758CF29ADF5D71965397B /* Pods-ProjetoTDBTests.debug.xcconfig */,
				33F274DAE6B8BF51E012D5A0 /* Pods-ProjetoTDBTests.release.xcconfig */,
				EC9518955A9836A53BE8F70D /* Pods-ProjetoTDBUITests.debug.xcconfig */,
				51C96B37795CE19A47BBEA9F /* Pods-ProjetoTDBUITests.release.xcconfig */,
			);
                name = Pods;
                sourceTree = '<group>';
            };
            29845B7ACE987AE38EEE5202 /* Frameworks */ = {
                isa = PBXGroup;
                children = (
                    AC09DC3B1F448A020085F926 /* GoogleToolboxForMac.framework */,
                    4659AE80D00AE7BCFA416C1C /* Pods_ProjetoTDB.framework */,
				15C09401CE504E77CAEB0B0B /* Pods_ProjetoTDBTests.framework */,
				D349E8C9968EDA9D6441E638 /* Pods_ProjetoTDBUITests.framework */,
			);
                name = Frameworks;
                sourceTree = '<group>';
            };
            5BB5E9491F30F9BE0098BDD0 = {
                isa = PBXGroup;
                children = (
                    5BB5E9541F30F9BE0098BDD0 /* ProjetoTDB */,
				5BB5E9691F30F9BF0098BDD0 /* ProjetoTDBTests */,
				5BB5E9741F30F9BF0098BDD0 /* ProjetoTDBUITests */,
				5BB5E9531F30F9BE0098BDD0 /* Products */,
				2877F6A988DF8023D2C937D0 /* Pods */,
				29845B7ACE987AE38EEE5202 /* Frameworks */,
			);
                sourceTree = '<group>';
            };
            5BB5E9531F30F9BE0098BDD0 /* Products */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9521F30F9BE0098BDD0 /* ProjetoTDB.app */,
				5BB5E9661F30F9BF0098BDD0 /* ProjetoTDBTests.xctest */,
				5BB5E9711F30F9BF0098BDD0 /* ProjetoTDBUITests.xctest */,
			);
                name = Products;
                sourceTree = '<group>';
            };
            5BB5E9541F30F9BE0098BDD0 /* ProjetoTDB */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9B01F30FA250098BDD0 /* Controller */,
				5BB613301F3367FC00D49E72 /* Custom Cells */,
				5BFAAE2C1F30FFBE00584F5C /* Imagens */,
				5BB5E9BA1F30FA2F0098BDD0 /* BusinessLayer */,
				5BB5E9B51F30FA2A0098BDD0 /* Commons */,
				5BB5E99D1F30FA1F0098BDD0 /* DataAccessLayer */,
				5BB5E98A1F30FA120098BDD0 /* Model */,
				5BB5E9831F30FA0A0098BDD0 /* View */,
				5BB5E9551F30F9BE0098BDD0 /* AppDelegate.swift */,
				5BB5E9591F30F9BE0098BDD0 /* Main.storyboard */,
				5BB5E95C1F30F9BE0098BDD0 /* Assets.xcassets */,
				5BB5E95E1F30F9BE0098BDD0 /* LaunchScreen.storyboard */,
				A5C3AF8F1F433CBF003F9A5B /* GoogleService-Info.plist */,
				5BB5E9611F30F9BE0098BDD0 /* Info.plist */,
			);
                path = ProjetoTDB;
                sourceTree = '<group>';
            };
            5BB5E9691F30F9BF0098BDD0 /* ProjetoTDBTests */ = {
                isa = PBXGroup;
                children = (
                    5BB5E96A1F30F9BF0098BDD0 /* ProjetoTDBTests.swift */,
				5BB5E96C1F30F9BF0098BDD0 /* Info.plist */,
			);
                path = ProjetoTDBTests;
                sourceTree = '<group>';
            };
            5BB5E9741F30F9BF0098BDD0 /* ProjetoTDBUITests */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9751F30F9BF0098BDD0 /* ProjetoTDBUITests.swift */,
				5BB5E9771F30F9BF0098BDD0 /* Info.plist */,
			);
                path = ProjetoTDBUITests;
                sourceTree = '<group>';
            };
            5BB5E9831F30FA0A0098BDD0 /* View */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9841F30FA0A0098BDD0 /* Instituicao.storyboard */,
				5BB5E9851F30FA0A0098BDD0 /* Perfil.storyboard */,
				5BB5E9861F30FA0A0098BDD0 /* Sincronizacao.storyboard */,
				5B3D10571F3267760099E2CB /* Evento.storyboard */,
				AC02A5A51F33B8350076FA5B /* Aluno.storyboard */,
				AC02A5AD1F389F6A0076FA5B /* AlunoDetalhe.storyboard */,
				5B515A1C1F3A387200A5BBBD /* PerguntasSocioEconomicas.storyboard */,
				AC02A5B71F3A46AB0076FA5B /* IHC.storyboard */,
				AC02A5B91F3A46FD0076FA5B /* Percepcoes.storyboard */,
				AC02A5BB1F3A47160076FA5B /* Foto.storyboard */,
				AC02A5BD1F3A472E0076FA5B /* Consideracoes.storyboard */,
				C61450851F4FA6DE00994EC3 /* SincronizacaoDetail.storyboard */,
				ACFDB0041F599A800030F23E /* UserOnboarding.storyboard */,
				5B71021C1F5ED2CD00E0DD68 /* PerfilAlterarSenha.storyboard */,
				ACFCA5431F69C7F300E88E03 /* Auxiliares.storyboard */,
				ACFCA5451F69C81600E88E03 /* Participantes.storyboard */,
			);
                path = View;
                sourceTree = '<group>';
            };
            5BB5E98A1F30FA120098BDD0 /* Model */ = {
                isa = PBXGroup;
                children = (
                    5BB5E98B1F30FA120098BDD0 /* AlunoTDBModel.swift */,
				5BB5E98C1F30FA120098BDD0 /* ConsideracaoTDBModel.swift */,
				5BB5E98D1F30FA120098BDD0 /* DocumentoTDBModel.swift */,
				5BB5E98E1F30FA120098BDD0 /* EventoTDBModel.swift */,
				5BB5E98F1F30FA120098BDD0 /* FotoTDBModel.swift */,
				5BB5E9901F30FA120098BDD0 /* IHCTDBModel.swift */,
				5BB5E9911F30FA120098BDD0 /* InstituicaoTDBModel.swift */,
				5BB5E9921F30FA120098BDD0 /* TipoFotoTDBModel.swift */,
				5BB5E9931F30FA120098BDD0 /* UsuarioTDBModel.swift */,
				5B3F5AF71F3B7DF300905BBB /* PerguntasSocioEconomicasTDBModel.swift */,
				5B3F5B051F3C91CB00905BBB /* PercepcoesTDBModel.swift */,
				ACFCA54D1F69D42000E88E03 /* AuxiliaresTDBModel.swift */,
				AC001E871F7197E600728E92 /* EventoUsuarioTDBModel.swift */,
				AC001E891F71985200728E92 /* InstituicaoUsuarioTDBModel.swift */,
			);
                path = Model;
                sourceTree = '<group>';
            };
            5BB5E99D1F30FA1F0098BDD0 /* DataAccessLayer */ = {
                isa = PBXGroup;
                children = (
                    C68ED3B31F50496000B48E9F /* Local */,
                    5BB5E99E1F30FA1F0098BDD0 /* AlunoTDBDAL.swift */,
				5BB5E99F1F30FA1F0098BDD0 /* ConsideracaoTDBDAL.swift */,
				5BB5E9A01F30FA1F0098BDD0 /* DocumentoTDBDAL.swift */,
				ACFCA54B1F69D3C600E88E03 /* AuxiliaresTDBDAL.swift */,
				5BB5E9A11F30FA1F0098BDD0 /* EventoTDBDAL.swift */,
				5BB5E9A21F30FA1F0098BDD0 /* FotoTDBDAL.swift */,
				5BB5E9A31F30FA1F0098BDD0 /* IHCTDBDAL.swift */,
				5BB5E9A41F30FA1F0098BDD0 /* InstituicaoTDBDAL.swift */,
				5BB5E9A51F30FA1F0098BDD0 /* TipoFotoTDBDAL.swift */,
				5BB5E9A61F30FA1F0098BDD0 /* UsuarioTDBDAL.swift */,
				5B3F5AFB1F3B7F1E00905BBB /* PerguntasSocioEconomicasTDBDAL.swift */,
				5B3F5B031F3C91B000905BBB /* PercepcoesTDBDAL.swift */,
				AC001E831F71971000728E92 /* InstituicaoUsuarioTDBDAL.swift */,
				AC001E851F71978A00728E92 /* EventoUsuarioTDBDAL.swift */,
			);
                path = DataAccessLayer;
                sourceTree = '<group>';
            };
            5BB5E9B01F30FA250098BDD0 /* Controller */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9B11F30FA250098BDD0 /* IntituicaoTDBViewController.swift */,
				C66B3B4C1F7E70AA00EA2122 /* IntituicaoTDBViewController+EmptyDataSet.swift */,
				5BB5E9B21F30FA250098BDD0 /* LoginTDBViewController.swift */,
				5B3D10551F3255330099E2CB /* PerfilTableViewController.swift */,
				AC02A5A11F3354F70076FA5B /* EventoTDBViewController.swift */,
				C66B3B551F7E761B00EA2122 /* EventoTDBViewController+EmptyDataSet.swift */,
				A53CB89B1F3BA64A000BE404 /* IHCTDBTableViewController.swift */,
				AC02A5A71F33BAB10076FA5B /* AlunoTDBViewController.swift */,
				C66B3B591F7E76B700EA2122 /* AlunoTDBViewController+EmptyDataSet.swift */,
				ACFDB0061F599CB20030F23E /* PageViewController.swift */,
				AC02A5AF1F38A1F50076FA5B /* AlunoDetalheTDBViewController.swift */,
				5B515A1E1F3A3B7B00A5BBBD /* PerguntasSocioEconomicasTableViewController.swift */,
				A53CB8931F3B3D23000BE404 /* FotoViewController.swift */,
				5B3F5AFD1F3B916D00905BBB /* ConsideracoesTableViewController.swift */,
				5B3F5B011F3C8BA400905BBB /* PercepcoesTDBTableViewController.swift */,
				A58DEC2C1F3DF4DF0039B90B /* FotoEditorViewController.swift */,
				C614507D1F4DBCE300994EC3 /* SincronizacaoViewController.swift */,
				C66B3B571F7E764D00EA2122 /* SincronizacaoViewController+EmptyDataSet.swift */,
				C61450871F4FAE4E00994EC3 /* SincronizacaoDetailViewController.swift */,
				5B71021E1F5ED32000E0DD68 /* PerfilAlterarSenhaTableViewController.swift */,
				ACFCA53F1F69A54600E88E03 /* ParticipantesViewController.swift */,
				ACFCA5511F69D50E00E88E03 /* AuxiliaresTDBViewController.swift */,
				AC001E631F6B225200728E92 /* AuxiliaresCadastroTableTableViewController.swift */,
				C67465891F6C1A5000888331 /* InstituicaoTDBViewController+SearchServices.swift */,
				5B9C16E01F7D79CB0068B1F4 /* MainTabBarViewController.swift */,
			);
                path = Controller;
                sourceTree = '<group>';
            };
            5BB5E9B51F30FA2A0098BDD0 /* Commons */ = {
                isa = PBXGroup;
                children = (
                    C66B3B531F7E726D00EA2122 /* UIScrollView+EmptyDataSet.h */,
                    C66B3B521F7E726C00EA2122 /* UIScrollView+EmptyDataSet.m */,
                    5BB5E9B61F30FA2A0098BDD0 /* Constantes.swift */,
				5BB5E9B71F30FA2A0098BDD0 /* LoadingView.swift */,
				5BA27EA21F31520D0036BA93 /* AlertaTela.swift */,
				5B515A1A1F38F25600A5BBBD /* FormatarData.swift */,
				5B2952F61F3CE37600449E7D /* GlobalCommom.swift */,
				C61450831F4F93A600994EC3 /* AlertControllerHelper.swift */,
				C68ED3B61F52269700B48E9F /* Extensions.swift */,
				C68ED3D11F5240D900B48E9F /* ApplicationMode.swift */,
				C68ED3D21F5240D900B48E9F /* ErrorAlertUtils.swift */,
				C68ED3D31F5240D900B48E9F /* TDBError.swift */,
				5B9C16DE1F7D6D4E0068B1F4 /* FieldText.swift */,
				C66B3B511F7E726C00EA2122 /* ProjetoTDB-Bridging-Header.h */,
				5BD64A081F82CCBA0035288C /* VerificarTabelas.swift */,
			);
                path = Commons;
                sourceTree = '<group>';
            };
            5BB5E9BA1F30FA2F0098BDD0 /* BusinessLayer */ = {
                isa = PBXGroup;
                children = (
                    5BB5E9BB1F30FA2F0098BDD0 /* AlunoTDBBL.swift */,
				5BB5E9BC1F30FA2F0098BDD0 /* ConsideracaoTDBBL.swift */,
				5BB5E9BD1F30FA2F0098BDD0 /* DocumentoTDBBL.swift */,
				5BB5E9BE1F30FA2F0098BDD0 /* EventoTDBBL.swift */,
				5BB5E9BF1F30FA2F0098BDD0 /* FotoTDBBL.swift */,
				5BB5E9C01F30FA2F0098BDD0 /* IHCTDBBL.swift */,
				5BB5E9C11F30FA2F0098BDD0 /* InstituicaoTDBBL.swift */,
				5BB5E9C21F30FA2F0098BDD0 /* TipoFotoTDBBL.swift */,
				5BB5E9C31F30FA2F0098BDD0 /* UsuarioTDBBL.swift */,
				C6065EBC1F69CC780097D3CA /* EventoTDBViewController+SearchServices.swift */,
				AC001E8D1F71992F00728E92 /* InstituicaoUsuarioTDBBL.swift */,
				5B3F5AF91F3B7EE500905BBB /* PerguntasSocioEconomicasTDBBL.swift */,
				5B3F5B071F3C91DB00905BBB /* PercepcoesTDBBL.swift */,
				C66F3B821F59B8EA00D87F2A /* SincronizacaoViewController+CloudServices.swift */,
				ACFCA54F1F69D49000E88E03 /* AuxiliaresTDBBL.swift */,
				C624EC871F6AC5EB008A7369 /* AlunoTDBViewController+SearchServices.swift */,
				AC001E8B1F71990600728E92 /* EventoUsuarioTDBBL.swift */,
			);
                path = BusinessLayer;
                sourceTree = '<group>';
            };
            5BB613301F3367FC00D49E72 /* Custom Cells */ = {
                isa = PBXGroup;
                children = (
                    AC02A59F1F32908E0076FA5B /* InstituicaoTableViewCell.swift */,
                    5BB613311F33683A00D49E72 /* EventoTableViewCell.swift */,
				AC02A5AB1F34EFFF0076FA5B /* AlunoTableViewCell.swift */,
				A53CB8911F3B3BF4000BE404 /* FotoTableViewCell.swift */,
				ACFCA5411F69A5A900E88E03 /* ParticipantesTableViewCell.swift */,
				ACFCA5531F6AC98A00E88E03 /* AuxiliaresTableViewCell.swift */,
			);
                name = 'Custom Cells';
                path = CustonsCells;
                sourceTree = '<group>';
            };
            5BB613331F339F2A00D49E72 /* Templates */ = {
                isa = PBXGroup;
                children = (
                    5BB613341F339F2A00D49E72 /* 01 iPhone 7@2x.png */,
				5BB613351F339F2A00D49E72 /* 02 iPhone 7 Plus@2x.png */,
				5BB613361F339F2A00D49E72 /* 03 login@2x.png */,
				5BB613371F339F2A00D49E72 /* 04 instituicoes@2x.png */,
				5BB613381F339F2A00D49E72 /* 05 descricao instituicoes@2x.png */,
				5BB613391F339F2A00D49E72 /* 06 descricao instituicoes alerta@2x.png */,
				5BB6133A1F339F2A00D49E72 /* 07 descricao Paciente - IHC@2x.png */,
				5BB6133B1F339F2A00D49E72 /* 08 descricao Paciente - Percepcoes@2x.png */,
				5BB6133C1F339F2A00D49E72 /* 09 descricao Paciente - Fotos@2x.png */,
				5BB6133D1F339F2A00D49E72 /* 10 descricao Paciente - Considerações@2x.png */,
				5BB6133E1F339F2A00D49E72 /* 11 sincronização@2x.png */,
			);
                path = Templates;
                sourceTree = '<group>';
            };
            5BFAAE2C1F30FFBE00584F5C /* Imagens */ = {
                isa = PBXGroup;
                children = (
                    C624EC891F6ACC22008A7369 /* Auxiliares */,
                    5B579D951F3E3B490020ABCA /* SearchBackground.png */,
				5B579D751F3E38770020ABCA /* instituicoes_fill.png */,
				5B579D761F3E38770020ABCA /* instituicoes_fill@2x.png */,
				5B579D771F3E38770020ABCA /* instituicoes_fill@3x.png */,
				5B579D781F3E38770020ABCA /* instituicoes_outline.png */,
				5B579D791F3E38770020ABCA /* perfil_fill.png */,
				5B579D7A1F3E38770020ABCA /* perfil_fill@2x.png */,
				5B579D7B1F3E38770020ABCA /* perfil_fill@3x.png */,
				5B579D7C1F3E38770020ABCA /* perfil_outline.png */,
				5B579D7D1F3E38770020ABCA /* perfil_outline@2x.png */,
				5B579D7E1F3E38770020ABCA /* perfil_outline@3x.png */,
				5B579D7F1F3E38770020ABCA /* sync_fill.png */,
				5B579D801F3E38770020ABCA /* sync_fill@2x.png */,
				5B579D811F3E38770020ABCA /* sync_fill@3x.png */,
				5B579D821F3E38770020ABCA /* sync_outline.png */,
				5B579D831F3E38770020ABCA /* sync_outline@2x.png */,
				5B579D841F3E38770020ABCA /* sync_outline@3x.png */,
				5B579D6F1F3E36B50020ABCA /* btn_perguntas_socioeconomicos.png */,
				5B579D701F3E36B50020ABCA /* btn_perguntas_socioeconomicos@2x.png */,
				5B579D711F3E36B50020ABCA /* btn_perguntas_socioeconomicos@3x.png */,
				5BB613331F339F2A00D49E72 /* Templates */,
				5BFAAE311F310CE700584F5C /* slide1_1.png */,
				A53CB89D1F3BA69C000BE404 /* dente.png */,
				5BFAAE2D1F30FFBE00584F5C /* login_TDB.png */,
				C614507F1F4F106900994EC3 /* login_TDB@2x.png */,
				C61450801F4F106900994EC3 /* login_TDB@3x.png */,
			);
                name = Imagens;
                path = View / Imagens;
                sourceTree = '<group>';
            };
            C624EC891F6ACC22008A7369 /* Auxiliares */ = {
                isa = PBXGroup;
                children = (
                    C624EC8A1F6ACC33008A7369 /* teamwork.png */,
                    C624EC8B1F6ACC33008A7369 /* teamwork@2x.png */,
                    C624EC8C1F6ACC33008A7369 /* teamwork@3x.png */,
    
                );
                name = Auxiliares;
                sourceTree = '<group>';
            };
            C68ED3B31F50496000B48E9F /* Local */ = {
                isa = PBXGroup;
                children = (
                    C68ED3B81F52353C00B48E9F /* DAOs */,
                    C68ED3B11F50495100B48E9F /* DatabaseManager.swift */,
                    C68ED3B41F504BA400B48E9F /* DatabaseSource.swift */,
    
                );
                name = Local;
                sourceTree = '<group>';
            };
            C68ED3B81F52353C00B48E9F /* DAOs */ = {
                isa = PBXGroup;
                children = (
                    C68ED3B91F52355600B48E9F /* AlunoDAO.swift */,
                    C68ED3BB1F52356100B48E9F /* ConsideracaoDAO.swift */,
                    C68ED3BD1F52356E00B48E9F /* DocumentoDAO.swift */,
                    C68ED3BF1F52357700B48E9F /* EventoDAO.swift */,
                    C68ED3C11F52358800B48E9F /* IHCDAO.swift */,
                    C68ED3C31F52359200B48E9F /* InstituicaoDAO.swift */,
                    C68ED3C51F52359E00B48E9F /* UsuarioDAO.swift */,
                    C68ED3C71F5235AB00B48E9F /* PerguntasSocioeconomicasDAO.swift */,
                    C68ED3C91F5235B300B48E9F /* PercepcoesDAO.swift */,
                    A5A6E8771F55C0F1000535A0 /* FotoDAO.swift */,
                    A5A6E8791F560A5B000535A0 /* TipoFotoDAO.swift */,
    
                );
                name = DAOs;
                sourceTree = '<group>';
            };
            /* End PBXGroup section */

            /* Begin PBXNativeTarget section */
            5BB5E9511F30F9BE0098BDD0 /* ProjetoTDB */ = {
                isa = PBXNativeTarget;
                buildConfigurationList = 5BB5E97A1F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDB' */;
                buildPhases = (
                    A39A9056AE7E403768930C53 /* [CP] Check Pods Manifest.lock */,
                    5BB5E94E1F30F9BE0098BDD0 /* Sources */,
				5BB5E94F1F30F9BE0098BDD0 /* Frameworks */,
				5BB5E9501F30F9BE0098BDD0 /* Resources */,
				87004CFFCEE11D4D58630014 /* [CP] Embed Pods Frameworks */,
				BB28CE9C44412AFF22C16DB4 /* [CP] Copy Pods Resources */,
			);
                buildRules = (
    
                );
                dependencies = (
    
                );
                name = ProjetoTDB;
                productName = ProjetoTDB;
                productReference = 5BB5E9521F30F9BE0098BDD0 /* ProjetoTDB.app */;
                productType = 'com.apple.product-type.application';
            };
            5BB5E9651F30F9BF0098BDD0 /* ProjetoTDBTests */ = {
                isa = PBXNativeTarget;
                buildConfigurationList = 5BB5E97D1F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDBTests' */;
                buildPhases = (
                    6EB230AB8A3529C79297996C /* [CP] Check Pods Manifest.lock */,
				5BB5E9621F30F9BF0098BDD0 /* Sources */,
				5BB5E9631F30F9BF0098BDD0 /* Frameworks */,
				5BB5E9641F30F9BF0098BDD0 /* Resources */,
				74240020138BBBF62EC83663 /* [CP] Embed Pods Frameworks */,
				6EE975E0AA3C8EC484952BF0 /* [CP] Copy Pods Resources */,
			);
                buildRules = (
    
                );
                dependencies = (
                    5BB5E9681F30F9BF0098BDD0 /* PBXTargetDependency */,
			);
                name = ProjetoTDBTests;
                productName = ProjetoTDBTests;
                productReference = 5BB5E9661F30F9BF0098BDD0 /* ProjetoTDBTests.xctest */;
                productType = 'com.apple.product-type.bundle.unit-test';
            };
            5BB5E9701F30F9BF0098BDD0 /* ProjetoTDBUITests */ = {
                isa = PBXNativeTarget;
                buildConfigurationList = 5BB5E9801F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDBUITests' */;
                buildPhases = (
                    719FF3938C06BC00A74424FF /* [CP] Check Pods Manifest.lock */,
				5BB5E96D1F30F9BF0098BDD0 /* Sources */,
				5BB5E96E1F30F9BF0098BDD0 /* Frameworks */,
				5BB5E96F1F30F9BF0098BDD0 /* Resources */,
				75D7232BDD8886DC049FFE29 /* [CP] Embed Pods Frameworks */,
				A91CB66CF0A2C30CE5912B6C /* [CP] Copy Pods Resources */,
			);
                buildRules = (
    
                );
                dependencies = (
                    5BB5E9731F30F9BF0098BDD0 /* PBXTargetDependency */,
			);
                name = ProjetoTDBUITests;
                productName = ProjetoTDBUITests;
                productReference = 5BB5E9711F30F9BF0098BDD0 /* ProjetoTDBUITests.xctest */;
                productType = 'com.apple.product-type.bundle.ui-testing';
            };
            /* End PBXNativeTarget section */

            /* Begin PBXProject section */
            5BB5E94A1F30F9BE0098BDD0 /* Project object */ = {
                isa = PBXProject;
                attributes = {
                    LastSwiftUpdateCheck = 0830;
                    LastUpgradeCheck = 0830;
                    ORGANIZATIONNAME = 'Mauricio Junior';
                    TargetAttributes = {
                        5BB5E9511F30F9BE0098BDD0 = {
                            CreatedOnToolsVersion = 8.3.3;
                            DevelopmentTeam = X234QR2N2U;
                            ProvisioningStyle = Automatic;
                        };
                        5BB5E9651F30F9BF0098BDD0 = {
                            CreatedOnToolsVersion = 8.3.3;
                            ProvisioningStyle = Automatic;
                            TestTargetID = 5BB5E9511F30F9BE0098BDD0;
                        };
                        5BB5E9701F30F9BF0098BDD0 = {
                            CreatedOnToolsVersion = 8.3.3;
                            ProvisioningStyle = Automatic;
                            TestTargetID = 5BB5E9511F30F9BE0098BDD0;
                        };
                    };
                };
                buildConfigurationList = 5BB5E94D1F30F9BE0098BDD0 /* Build configuration list for PBXProject 'ProjetoTDB' */;
                compatibilityVersion = 'Xcode 3.2';
                developmentRegion = English;
                hasScannedForEncodings = 0;
                knownRegions = (
                    en,
                    Base,
    
                );
                mainGroup = 5BB5E9491F30F9BE0098BDD0;
                productRefGroup = 5BB5E9531F30F9BE0098BDD0 /* Products */;
                projectDirPath = '';
                projectRoot = '';
                targets = (
                    5BB5E9511F30F9BE0098BDD0 /* ProjetoTDB */,
				5BB5E9651F30F9BF0098BDD0 /* ProjetoTDBTests */,
				5BB5E9701F30F9BF0098BDD0 /* ProjetoTDBUITests */,
			);
            };
            /* End PBXProject section */

            /* Begin PBXResourcesBuildPhase section */
            5BB5E9501F30F9BE0098BDD0 /* Resources */ = {
                isa = PBXResourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    5B579D871F3E38770020ABCA /* instituicoes_fill@3x.png in Resources */,
				5B579D8A1F3E38770020ABCA /* perfil_fill@2x.png in Resources */,
				AC02A5B81F3A46AB0076FA5B /* IHC.storyboard in Resources */,
				5BB6133F1F339F2A00D49E72 /* 01 iPhone 7@2x.png in Resources */,
				5B515A1D1F3A387200A5BBBD /* PerguntasSocioEconomicas.storyboard in Resources */,
				5B579D721F3E36B50020ABCA /* btn_perguntas_socioeconomicos.png in Resources */,
				5B579D861F3E38770020ABCA /* instituicoes_fill@2x.png in Resources */,
				5B579D8F1F3E38770020ABCA /* sync_fill.png in Resources */,
				5BFAAE321F310CE700584F5C /* slide1_1.png in Resources */,
				5B579D8E1F3E38770020ABCA /* perfil_outline@3x.png in Resources */,
				C624EC8F1F6ACC33008A7369 /* teamwork@3x.png in Resources */,
				A5C3AF901F433CBF003F9A5B /* GoogleService-Info.plist in Resources */,
				ACFCA5441F69C7F300E88E03 /* Auxiliares.storyboard in Resources */,
				5BB613431F339F2A00D49E72 /* 05 descricao instituicoes@2x.png in Resources */,
				5BB613441F339F2A00D49E72 /* 06 descricao instituicoes alerta@2x.png in Resources */,
				5B579D881F3E38770020ABCA /* instituicoes_outline.png in Resources */,
				5BB613461F339F2A00D49E72 /* 08 descricao Paciente - Percepcoes@2x.png in Resources */,
				5B579D891F3E38770020ABCA /* perfil_fill.png in Resources */,
				5B579D921F3E38770020ABCA /* sync_outline.png in Resources */,
				5BB613421F339F2A00D49E72 /* 04 instituicoes@2x.png in Resources */,
				5B3D10581F3267760099E2CB /* Evento.storyboard in Resources */,
				5B579D8B1F3E38770020ABCA /* perfil_fill@3x.png in Resources */,
				C61450821F4F106900994EC3 /* login_TDB@3x.png in Resources */,
				AC02A5BE1F3A472E0076FA5B /* Consideracoes.storyboard in Resources */,
				5BFAAE2F1F30FFBE00584F5C /* login_TDB.png in Resources */,
				5B579D911F3E38770020ABCA /* sync_fill@3x.png in Resources */,
				A53CB89E1F3BA69C000BE404 /* dente.png in Resources */,
				5B579D731F3E36B50020ABCA /* btn_perguntas_socioeconomicos@2x.png in Resources */,
				5B579D851F3E38770020ABCA /* instituicoes_fill.png in Resources */,
				ACFDB0051F599A800030F23E /* UserOnboarding.storyboard in Resources */,
				C61450861F4FA6DE00994EC3 /* SincronizacaoDetail.storyboard in Resources */,
				ACFCA5461F69C81600E88E03 /* Participantes.storyboard in Resources */,
				5BB613471F339F2A00D49E72 /* 09 descricao Paciente - Fotos@2x.png in Resources */,
				5B579D8C1F3E38770020ABCA /* perfil_outline.png in Resources */,
				5BB5E9601F30F9BE0098BDD0 /* LaunchScreen.storyboard in Resources */,
				5B71021D1F5ED2CD00E0DD68 /* PerfilAlterarSenha.storyboard in Resources */,
				5B579D941F3E38770020ABCA /* sync_outline@3x.png in Resources */,
				5BB5E9871F30FA0A0098BDD0 /* Instituicao.storyboard in Resources */,
				AC02A5AE1F389F6A0076FA5B /* AlunoDetalhe.storyboard in Resources */,
				5BB5E9881F30FA0A0098BDD0 /* Perfil.storyboard in Resources */,
				5BB613401F339F2A00D49E72 /* 02 iPhone 7 Plus@2x.png in Resources */,
				AC02A5BC1F3A47160076FA5B /* Foto.storyboard in Resources */,
				AC02A5A61F33B8350076FA5B /* Aluno.storyboard in Resources */,
				C624EC8E1F6ACC33008A7369 /* teamwork@2x.png in Resources */,
				5BB5E95D1F30F9BE0098BDD0 /* Assets.xcassets in Resources */,
				5BB613491F339F2A00D49E72 /* 11 sincronização@2x.png in Resources */,
				5B579D741F3E36B50020ABCA /* btn_perguntas_socioeconomicos@3x.png in Resources */,
				5BB613481F339F2A00D49E72 /* 10 descricao Paciente - Considerações@2x.png in Resources */,
				AC02A5BA1F3A46FD0076FA5B /* Percepcoes.storyboard in Resources */,
				5BB613451F339F2A00D49E72 /* 07 descricao Paciente - IHC@2x.png in Resources */,
				5B579D961F3E3B490020ABCA /* SearchBackground.png in Resources */,
				C61450811F4F106900994EC3 /* login_TDB@2x.png in Resources */,
				5BB5E9891F30FA0A0098BDD0 /* Sincronizacao.storyboard in Resources */,
				C624EC8D1F6ACC33008A7369 /* teamwork.png in Resources */,
				5B579D931F3E38770020ABCA /* sync_outline@2x.png in Resources */,
				5B579D901F3E38770020ABCA /* sync_fill@2x.png in Resources */,
				5B579D8D1F3E38770020ABCA /* perfil_outline@2x.png in Resources */,
				5BB613411F339F2A00D49E72 /* 03 login@2x.png in Resources */,
				5BB5E95B1F30F9BE0098BDD0 /* Main.storyboard in Resources */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E9641F30F9BF0098BDD0 /* Resources */ = {
                isa = PBXResourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E96F1F30F9BF0098BDD0 /* Resources */ = {
                isa = PBXResourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
            };
            /* End PBXResourcesBuildPhase section */

            /* Begin PBXShellScriptBuildPhase section */
            6EB230AB8A3529C79297996C /* [CP] Check Pods Manifest.lock */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
                    '${PODS_PODFILE_DIR_PATH}/Podfile.lock',
                    '${PODS_ROOT}/Manifest.lock',
    
                );
                name = '[CP] Check Pods Manifest.lock';
                outputPaths = (
                    '$(DERIVED_FILE_DIR)/Pods-ProjetoTDBTests-checkManifestLockResult.txt',
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = 'diff \'${PODS_ROOT}/../Podfile.lock\' \'${PODS_ROOT}/Manifest.lock\' > /dev/null\nif [ $? != 0 ] ; then\n    # print error to STDERR\n    echo \'error: The sandbox is not in sync with the Podfile.lock. Run 'pod install' or update your CocoaPods installation.\' >&2\n    exit 1\nfi\n';
                showEnvVarsInLog = 0;
            };
            6EE975E0AA3C8EC484952BF0 /* [CP] Copy Pods Resources */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
    
                );
                name = '[CP] Copy Pods Resources';
                outputPaths = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDBTests/Pods-ProjetoTDBTests-resources.sh\'\n';
                showEnvVarsInLog = 0;
            };
            719FF3938C06BC00A74424FF /* [CP] Check Pods Manifest.lock */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
                    '${PODS_PODFILE_DIR_PATH}/Podfile.lock',
                    '${PODS_ROOT}/Manifest.lock',
    
                );
                name = '[CP] Check Pods Manifest.lock';
                outputPaths = (
                    '$(DERIVED_FILE_DIR)/Pods-ProjetoTDBUITests-checkManifestLockResult.txt',
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = 'diff \'${PODS_ROOT}/../Podfile.lock\' \'${PODS_ROOT}/Manifest.lock\' > /dev/null\nif [ $? != 0 ] ; then\n    # print error to STDERR\n    echo \'error: The sandbox is not in sync with the Podfile.lock. Run 'pod install' or update your CocoaPods installation.\' >&2\n    exit 1\nfi\n';
                showEnvVarsInLog = 0;
            };
            74240020138BBBF62EC83663 /* [CP] Embed Pods Frameworks */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
    
                );
                name = '[CP] Embed Pods Frameworks';
                outputPaths = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDBTests/Pods-ProjetoTDBTests-frameworks.sh\'\n';
                showEnvVarsInLog = 0;
            };
            75D7232BDD8886DC049FFE29 /* [CP] Embed Pods Frameworks */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
    
                );
                name = '[CP] Embed Pods Frameworks';
                outputPaths = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDBUITests/Pods-ProjetoTDBUITests-frameworks.sh\'\n';
                showEnvVarsInLog = 0;
            };
            87004CFFCEE11D4D58630014 /* [CP] Embed Pods Frameworks */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
                    '${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDB/Pods-ProjetoTDB-frameworks.sh',
                    '${BUILT_PRODUCTS_DIR}/Alamofire/Alamofire.framework',
                    '${BUILT_PRODUCTS_DIR}/GTMSessionFetcher/GTMSessionFetcher.framework',
                    '${BUILT_PRODUCTS_DIR}/GoogleToolboxForMac/GoogleToolboxForMac.framework',
                    '${BUILT_PRODUCTS_DIR}/NVActivityIndicatorView/NVActivityIndicatorView.framework',
                    '${BUILT_PRODUCTS_DIR}/ReachabilitySwift/ReachabilitySwift.framework',
                    '${BUILT_PRODUCTS_DIR}/SQLite.swift/SQLite.framework',
                    '${BUILT_PRODUCTS_DIR}/SwiftyJSON/SwiftyJSON.framework',
                    '${BUILT_PRODUCTS_DIR}/Toast-Swift/Toast_Swift.framework',
                    '${BUILT_PRODUCTS_DIR}/nanopb/nanopb.framework',
    
                );
                name = '[CP] Embed Pods Frameworks';
                outputPaths = (
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/Alamofire.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/GTMSessionFetcher.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/GoogleToolboxForMac.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/NVActivityIndicatorView.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/ReachabilitySwift.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/SQLite.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/SwiftyJSON.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/Toast_Swift.framework',
                    '${TARGET_BUILD_DIR}/${FRAMEWORKS_FOLDER_PATH}/nanopb.framework',
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDB/Pods-ProjetoTDB-frameworks.sh\'\n';
                showEnvVarsInLog = 0;
            };
            A39A9056AE7E403768930C53 /* [CP] Check Pods Manifest.lock */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
                    '${PODS_PODFILE_DIR_PATH}/Podfile.lock',
                    '${PODS_ROOT}/Manifest.lock',
    
                );
                name = '[CP] Check Pods Manifest.lock';
                outputPaths = (
                    '$(DERIVED_FILE_DIR)/Pods-ProjetoTDB-checkManifestLockResult.txt',
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = 'diff \'${PODS_ROOT}/../Podfile.lock\' \'${PODS_ROOT}/Manifest.lock\' > /dev/null\nif [ $? != 0 ] ; then\n    # print error to STDERR\n    echo \'error: The sandbox is not in sync with the Podfile.lock. Run 'pod install' or update your CocoaPods installation.\' >&2\n    exit 1\nfi\n';
                showEnvVarsInLog = 0;
            };
            A91CB66CF0A2C30CE5912B6C /* [CP] Copy Pods Resources */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
    
                );
                name = '[CP] Copy Pods Resources';
                outputPaths = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDBUITests/Pods-ProjetoTDBUITests-resources.sh\'\n';
                showEnvVarsInLog = 0;
            };
            BB28CE9C44412AFF22C16DB4 /* [CP] Copy Pods Resources */ = {
                isa = PBXShellScriptBuildPhase;
                buildActionMask = 2147483647;
                files = (
    
                );
                inputPaths = (
    
                );
                name = '[CP] Copy Pods Resources';
                outputPaths = (
    
                );
                runOnlyForDeploymentPostprocessing = 0;
                shellPath = / bin / sh;
                shellScript = '\'${SRCROOT}/Pods/Target Support Files/Pods-ProjetoTDB/Pods-ProjetoTDB-resources.sh\'\n';
                showEnvVarsInLog = 0;
            };
            /* End PBXShellScriptBuildPhase section */

            /* Begin PBXSourcesBuildPhase section */
            5BB5E94E1F30F9BE0098BDD0 /* Sources */ = {
                isa = PBXSourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    C614507E1F4DBCE300994EC3 /* SincronizacaoViewController.swift in Sources */,
                    C68ED3D51F5240D900B48E9F /* ErrorAlertUtils.swift in Sources */,
                    ACFCA5541F6AC98A00E88E03 /* AuxiliaresTableViewCell.swift in Sources */,
                    5BB5E9CA1F30FA2F0098BDD0 /* InstituicaoTDBBL.swift in Sources */,
				A53CB89C1F3BA64A000BE404 /* IHCTDBTableViewController.swift in Sources */,
				5BB5E99B1F30FA120098BDD0 /* TipoFotoTDBModel.swift in Sources */,
				5B515A1F1F3A3B7B00A5BBBD /* PerguntasSocioEconomicasTableViewController.swift in Sources */,
				5BB5E9C91F30FA2F0098BDD0 /* IHCTDBBL.swift in Sources */,
				C61450841F4F93A600994EC3 /* AlertControllerHelper.swift in Sources */,
				5BB5E9941F30FA120098BDD0 /* AlunoTDBModel.swift in Sources */,
				AC001E641F6B225200728E92 /* AuxiliaresCadastroTableTableViewController.swift in Sources */,
				C66B3B561F7E761B00EA2122 /* EventoTDBViewController+EmptyDataSet.swift in Sources */,
				AC001E881F7197E600728E92 /* EventoUsuarioTDBModel.swift in Sources */,
				5BB5E9981F30FA120098BDD0 /* FotoTDBModel.swift in Sources */,
				ACFCA5421F69A5A900E88E03 /* ParticipantesTableViewCell.swift in Sources */,
				AC001E8C1F71990600728E92 /* EventoUsuarioTDBBL.swift in Sources */,
				5BB5E9C61F30FA2F0098BDD0 /* DocumentoTDBBL.swift in Sources */,
				AC02A5A21F3354F70076FA5B /* EventoTDBViewController.swift in Sources */,
				C66F3B831F59B8EA00D87F2A /* SincronizacaoViewController+CloudServices.swift in Sources */,
				C68ED3CA1F5235B300B48E9F /* PercepcoesDAO.swift in Sources */,
				5BA27EA31F31520D0036BA93 /* AlertaTela.swift in Sources */,
				5BB5E9B41F30FA250098BDD0 /* LoginTDBViewController.swift in Sources */,
				5BB5E9B91F30FA2A0098BDD0 /* LoadingView.swift in Sources */,
				5BB5E99A1F30FA120098BDD0 /* InstituicaoTDBModel.swift in Sources */,
				ACFCA54C1F69D3C600E88E03 /* AuxiliaresTDBDAL.swift in Sources */,
				AC001E861F71978A00728E92 /* EventoUsuarioTDBDAL.swift in Sources */,
				C68ED3BC1F52356100B48E9F /* ConsideracaoDAO.swift in Sources */,
				5BB5E9CB1F30FA2F0098BDD0 /* TipoFotoTDBBL.swift in Sources */,
				A53CB8921F3B3BF4000BE404 /* FotoTableViewCell.swift in Sources */,
				5B3F5B021F3C8BA400905BBB /* PercepcoesTDBTableViewController.swift in Sources */,
				C68ED3B71F52269700B48E9F /* Extensions.swift in Sources */,
				5BB5E9AD1F30FA1F0098BDD0 /* InstituicaoTDBDAL.swift in Sources */,
				AC02A5A01F32908E0076FA5B /* InstituicaoTableViewCell.swift in Sources */,
				ACFCA5521F69D50E00E88E03 /* AuxiliaresTDBViewController.swift in Sources */,
				5B71021F1F5ED32000E0DD68 /* PerfilAlterarSenhaTableViewController.swift in Sources */,
				ACFCA5401F69A54600E88E03 /* ParticipantesViewController.swift in Sources */,
				AC001E841F71971000728E92 /* InstituicaoUsuarioTDBDAL.swift in Sources */,
				5BB5E9991F30FA120098BDD0 /* IHCTDBModel.swift in Sources */,
				AC001E8A1F71985200728E92 /* InstituicaoUsuarioTDBModel.swift in Sources */,
				5BB5E9B81F30FA2A0098BDD0 /* Constantes.swift in Sources */,
				5BB5E9C41F30FA2F0098BDD0 /* AlunoTDBBL.swift in Sources */,
				AC001E8E1F71992F00728E92 /* InstituicaoUsuarioTDBBL.swift in Sources */,
				C68ED3BE1F52356E00B48E9F /* DocumentoDAO.swift in Sources */,
				C68ED3C21F52358800B48E9F /* IHCDAO.swift in Sources */,
				5BB5E9961F30FA120098BDD0 /* DocumentoTDBModel.swift in Sources */,
				A5A6E8781F55C0F1000535A0 /* FotoDAO.swift in Sources */,
				C66B3B4D1F7E70AA00EA2122 /* IntituicaoTDBViewController+EmptyDataSet.swift in Sources */,
				5B3F5B061F3C91CB00905BBB /* PercepcoesTDBModel.swift in Sources */,
				5B3F5AFC1F3B7F1E00905BBB /* PerguntasSocioEconomicasTDBDAL.swift in Sources */,
				5BB5E9C71F30FA2F0098BDD0 /* EventoTDBBL.swift in Sources */,
				5B3D10561F3255330099E2CB /* PerfilTableViewController.swift in Sources */,
				C68ED3C81F5235AB00B48E9F /* PerguntasSocioeconomicasDAO.swift in Sources */,
				C61450881F4FAE4E00994EC3 /* SincronizacaoDetailViewController.swift in Sources */,
				5B9C16DF1F7D6D4E0068B1F4 /* FieldText.swift in Sources */,
				5BB5E9971F30FA120098BDD0 /* EventoTDBModel.swift in Sources */,
				ACFCA5501F69D49000E88E03 /* AuxiliaresTDBBL.swift in Sources */,
				5BB5E9AF1F30FA1F0098BDD0 /* UsuarioTDBDAL.swift in Sources */,
				C68ED3B21F50495100B48E9F /* DatabaseManager.swift in Sources */,
				5BB613321F33683A00D49E72 /* EventoTableViewCell.swift in Sources */,
				C66B3B581F7E764D00EA2122 /* SincronizacaoViewController+EmptyDataSet.swift in Sources */,
				5B3F5AFE1F3B916D00905BBB /* ConsideracoesTableViewController.swift in Sources */,
				5BB5E9AE1F30FA1F0098BDD0 /* TipoFotoTDBDAL.swift in Sources */,
				5BB5E9C51F30FA2F0098BDD0 /* ConsideracaoTDBBL.swift in Sources */,
				5BB5E9CC1F30FA2F0098BDD0 /* UsuarioTDBBL.swift in Sources */,
				5BB5E9A81F30FA1F0098BDD0 /* ConsideracaoTDBDAL.swift in Sources */,
				C68ED3B51F504BA400B48E9F /* DatabaseSource.swift in Sources */,
				C674658A1F6C1A5000888331 /* InstituicaoTDBViewController+SearchServices.swift in Sources */,
				5BB5E9561F30F9BE0098BDD0 /* AppDelegate.swift in Sources */,
				C66B3B5A1F7E76B700EA2122 /* AlunoTDBViewController+EmptyDataSet.swift in Sources */,
				5BB5E9B31F30FA250098BDD0 /* IntituicaoTDBViewController.swift in Sources */,
				5B9C16E11F7D79CB0068B1F4 /* MainTabBarViewController.swift in Sources */,
				5BB5E99C1F30FA120098BDD0 /* UsuarioTDBModel.swift in Sources */,
				5BB5E9AC1F30FA1F0098BDD0 /* IHCTDBDAL.swift in Sources */,
				A58DEC2D1F3DF4DF0039B90B /* FotoEditorViewController.swift in Sources */,
				5BB5E9A71F30FA1F0098BDD0 /* AlunoTDBDAL.swift in Sources */,
				5BB5E9951F30FA120098BDD0 /* ConsideracaoTDBModel.swift in Sources */,
				AC02A5A81F33BAB10076FA5B /* AlunoTDBViewController.swift in Sources */,
				5B3F5B081F3C91DB00905BBB /* PercepcoesTDBBL.swift in Sources */,
				5BB5E9A91F30FA1F0098BDD0 /* DocumentoTDBDAL.swift in Sources */,
				5BB5E9AB1F30FA1F0098BDD0 /* FotoTDBDAL.swift in Sources */,
				C68ED3D41F5240D900B48E9F /* ApplicationMode.swift in Sources */,
				5BD64A091F82CCBA0035288C /* VerificarTabelas.swift in Sources */,
				C68ED3D61F5240D900B48E9F /* TDBError.swift in Sources */,
				5B515A1B1F38F25600A5BBBD /* FormatarData.swift in Sources */,
				5B3F5B041F3C91B000905BBB /* PercepcoesTDBDAL.swift in Sources */,
				C68ED3BA1F52355600B48E9F /* AlunoDAO.swift in Sources */,
				ACFCA54E1F69D42000E88E03 /* AuxiliaresTDBModel.swift in Sources */,
				AC02A5AC1F34EFFF0076FA5B /* AlunoTableViewCell.swift in Sources */,
				C68ED3C41F52359200B48E9F /* InstituicaoDAO.swift in Sources */,
				AC02A5B01F38A1F60076FA5B /* AlunoDetalheTDBViewController.swift in Sources */,
				C68ED3C01F52357700B48E9F /* EventoDAO.swift in Sources */,
				C68ED3C61F52359E00B48E9F /* UsuarioDAO.swift in Sources */,
				C66B3B541F7E726D00EA2122 /* UIScrollView+EmptyDataSet.m in Sources */,
				5B3F5AFA1F3B7EE500905BBB /* PerguntasSocioEconomicasTDBBL.swift in Sources */,
				5BB5E9AA1F30FA1F0098BDD0 /* EventoTDBDAL.swift in Sources */,
				A53CB8941F3B3D23000BE404 /* FotoViewController.swift in Sources */,
				ACFDB0071F599CB20030F23E /* PageViewController.swift in Sources */,
				C6065EBD1F69CC780097D3CA /* EventoTDBViewController+SearchServices.swift in Sources */,
				C624EC881F6AC5EB008A7369 /* AlunoTDBViewController+SearchServices.swift in Sources */,
				A5A6E87A1F560A5B000535A0 /* TipoFotoDAO.swift in Sources */,
				5B3F5AF81F3B7DF300905BBB /* PerguntasSocioEconomicasTDBModel.swift in Sources */,
				5BB5E9C81F30FA2F0098BDD0 /* FotoTDBBL.swift in Sources */,
				5B2952F71F3CE37600449E7D /* GlobalCommom.swift in Sources */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E9621F30F9BF0098BDD0 /* Sources */ = {
                isa = PBXSourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    5BB5E96B1F30F9BF0098BDD0 /* ProjetoTDBTests.swift in Sources */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            5BB5E96D1F30F9BF0098BDD0 /* Sources */ = {
                isa = PBXSourcesBuildPhase;
                buildActionMask = 2147483647;
                files = (
                    5BB5E9761F30F9BF0098BDD0 /* ProjetoTDBUITests.swift in Sources */,
			);
                runOnlyForDeploymentPostprocessing = 0;
            };
            /* End PBXSourcesBuildPhase section */

            /* Begin PBXTargetDependency section */
            5BB5E9681F30F9BF0098BDD0 /* PBXTargetDependency */ = {
                isa = PBXTargetDependency;
                target = 5BB5E9511F30F9BE0098BDD0 /* ProjetoTDB */;
                targetProxy = 5BB5E9671F30F9BF0098BDD0 /* PBXContainerItemProxy */;
            };
            5BB5E9731F30F9BF0098BDD0 /* PBXTargetDependency */ = {
                isa = PBXTargetDependency;
                target = 5BB5E9511F30F9BE0098BDD0 /* ProjetoTDB */;
                targetProxy = 5BB5E9721F30F9BF0098BDD0 /* PBXContainerItemProxy */;
            };
            /* End PBXTargetDependency section */

            /* Begin PBXVariantGroup section */
            5BB5E9591F30F9BE0098BDD0 /* Main.storyboard */ = {
                isa = PBXVariantGroup;
                children = (
                    5BB5E95A1F30F9BE0098BDD0 /* Base */,
			);
                name = Main.storyboard;
                sourceTree = '<group>';
            };
            5BB5E95E1F30F9BE0098BDD0 /* LaunchScreen.storyboard */ = {
                isa = PBXVariantGroup;
                children = (
                    5BB5E95F1F30F9BE0098BDD0 /* Base */,
			);
                name = LaunchScreen.storyboard;
                sourceTree = '<group>';
            };
            /* End PBXVariantGroup section */

            /* Begin XCBuildConfiguration section */
            5BB5E9781F30F9BF0098BDD0 /* Debug */ = {
                isa = XCBuildConfiguration;
                buildSettings = {
                    ALWAYS_SEARCH_USER_PATHS = NO;
                    CLANG_ANALYZER_NONNULL = YES;
                    CLANG_ANALYZER_NUMBER_OBJECT_CONVERSION = YES_AGGRESSIVE;
                    CLANG_CXX_LANGUAGE_STANDARD = 'gnu++0x';
                    CLANG_CXX_LIBRARY = 'libc++';
                    CLANG_ENABLE_MODULES = YES;
                    CLANG_ENABLE_OBJC_ARC = YES;
                    CLANG_WARN_BOOL_CONVERSION = YES;
                    CLANG_WARN_CONSTANT_CONVERSION = YES;
                    CLANG_WARN_DIRECT_OBJC_ISA_USAGE = YES_ERROR;
                    CLANG_WARN_DOCUMENTATION_COMMENTS = YES;
                    CLANG_WARN_EMPTY_BODY = YES;
                    CLANG_WARN_ENUM_CONVERSION = YES;
                    CLANG_WARN_INFINITE_RECURSION = YES;
                    CLANG_WARN_INT_CONVERSION = YES;
                    CLANG_WARN_OBJC_ROOT_CLASS = YES_ERROR;
                    CLANG_WARN_SUSPICIOUS_MOVE = YES;
                    CLANG_WARN_UNREACHABLE_CODE = YES;
                    CLANG_WARN__DUPLICATE_METHOD_MATCH = YES;
                    CODE_SIGN_IDENTITY = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    'CODE_SIGN_IDENTITY[sdk=iphoneos*]' = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    COPY_PHASE_STRIP = NO;
                    DEBUG_INFORMATION_FORMAT = dwarf;
                    ENABLE_STRICT_OBJC_MSGSEND = YES;
                    ENABLE_TESTABILITY = YES;
                    GCC_C_LANGUAGE_STANDARD = gnu99;
                    GCC_DYNAMIC_NO_PIC = NO;
                    GCC_NO_COMMON_BLOCKS = YES;
                    GCC_OPTIMIZATION_LEVEL = 0;
                    GCC_PREPROCESSOR_DEFINITIONS = (
                        'DEBUG=1',
                        '$(inherited)',
    
                    );
                    GCC_WARN_64_TO_32_BIT_CONVERSION = YES;
                    GCC_WARN_ABOUT_RETURN_TYPE = YES_ERROR;
                    GCC_WARN_UNDECLARED_SELECTOR = YES;
                    GCC_WARN_UNINITIALIZED_AUTOS = YES_AGGRESSIVE;
                    GCC_WARN_UNUSED_FUNCTION = YES;
                    GCC_WARN_UNUSED_VARIABLE = YES;
                    IPHONEOS_DEPLOYMENT_TARGET = 10.3;
                    MTL_ENABLE_DEBUG_INFO = YES;
                    ONLY_ACTIVE_ARCH = YES;
                    SDKROOT = iphoneos;
                    SWIFT_ACTIVE_COMPILATION_CONDITIONS = DEBUG;
                    SWIFT_OPTIMIZATION_LEVEL = '-Onone';
                };
                name = Debug;
            };
            5BB5E9791F30F9BF0098BDD0 /* Release */ = {
                isa = XCBuildConfiguration;
                buildSettings = {
                    ALWAYS_SEARCH_USER_PATHS = NO;
                    CLANG_ANALYZER_NONNULL = YES;
                    CLANG_ANALYZER_NUMBER_OBJECT_CONVERSION = YES_AGGRESSIVE;
                    CLANG_CXX_LANGUAGE_STANDARD = 'gnu++0x';
                    CLANG_CXX_LIBRARY = 'libc++';
                    CLANG_ENABLE_MODULES = YES;
                    CLANG_ENABLE_OBJC_ARC = YES;
                    CLANG_WARN_BOOL_CONVERSION = YES;
                    CLANG_WARN_CONSTANT_CONVERSION = YES;
                    CLANG_WARN_DIRECT_OBJC_ISA_USAGE = YES_ERROR;
                    CLANG_WARN_DOCUMENTATION_COMMENTS = YES;
                    CLANG_WARN_EMPTY_BODY = YES;
                    CLANG_WARN_ENUM_CONVERSION = YES;
                    CLANG_WARN_INFINITE_RECURSION = YES;
                    CLANG_WARN_INT_CONVERSION = YES;
                    CLANG_WARN_OBJC_ROOT_CLASS = YES_ERROR;
                    CLANG_WARN_SUSPICIOUS_MOVE = YES;
                    CLANG_WARN_UNREACHABLE_CODE = YES;
                    CLANG_WARN__DUPLICATE_METHOD_MATCH = YES;
                    CODE_SIGN_IDENTITY = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    'CODE_SIGN_IDENTITY[sdk=iphoneos*]' = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    COPY_PHASE_STRIP = NO;
                    DEBUG_INFORMATION_FORMAT = 'dwarf-with-dsym';
                    ENABLE_NS_ASSERTIONS = NO;
                    ENABLE_STRICT_OBJC_MSGSEND = YES;
                    GCC_C_LANGUAGE_STANDARD = gnu99;
                    GCC_NO_COMMON_BLOCKS = YES;
                    GCC_WARN_64_TO_32_BIT_CONVERSION = YES;
                    GCC_WARN_ABOUT_RETURN_TYPE = YES_ERROR;
                    GCC_WARN_UNDECLARED_SELECTOR = YES;
                    GCC_WARN_UNINITIALIZED_AUTOS = YES_AGGRESSIVE;
                    GCC_WARN_UNUSED_FUNCTION = YES;
                    GCC_WARN_UNUSED_VARIABLE = YES;
                    IPHONEOS_DEPLOYMENT_TARGET = 10.3;
                    MTL_ENABLE_DEBUG_INFO = NO;
                    SDKROOT = iphoneos;
                    SWIFT_OPTIMIZATION_LEVEL = '-Owholemodule';
                    VALIDATE_PRODUCT = YES;
                };
                name = Release;
            };
            5BB5E97B1F30F9BF0098BDD0 /* Debug */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = 90AD77D84E5E1F5E3EDB38DC /* Pods-ProjetoTDB.debug.xcconfig */;
                buildSettings = {
                    ASSETCATALOG_COMPILER_APPICON_NAME = AppIcon;
                    CLANG_ENABLE_MODULES = YES;
                    CODE_SIGN_IDENTITY = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    'CODE_SIGN_IDENTITY[sdk=iphoneos*]' = 'iPhone Developer';
                    CODE_SIGN_STYLE = Automatic;
                    DEVELOPMENT_TEAM = X234QR2N2U;
                    INFOPLIST_FILE = ProjetoTDB / Info.plist;
                    IPHONEOS_DEPLOYMENT_TARGET = 10.3;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = ucb.br.turmadobem;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    PROVISIONING_PROFILE = '';
                    PROVISIONING_PROFILE_SPECIFIER = '';
                    SWIFT_OBJC_BRIDGING_HEADER = 'ProjetoTDB/Commons/ProjetoTDB-Bridging-Header.h';
                    SWIFT_OPTIMIZATION_LEVEL = '-Onone';
                    SWIFT_VERSION = 3.0;
                };
                name = Debug;
            };
            5BB5E97C1F30F9BF0098BDD0 /* Release */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = 5BB0604660E74FAC771A7C41 /* Pods-ProjetoTDB.release.xcconfig */;
                buildSettings = {
                    ASSETCATALOG_COMPILER_APPICON_NAME = AppIcon;
                    CLANG_ENABLE_MODULES = YES;
                    CODE_SIGN_IDENTITY = 'iPhone Distribution: Mauricio Junior (X234QR2N2U)';
                    'CODE_SIGN_IDENTITY[sdk=iphoneos*]' = 'iPhone Developer';
                    CODE_SIGN_STYLE = Automatic;
                    DEVELOPMENT_TEAM = X234QR2N2U;
                    INFOPLIST_FILE = ProjetoTDB / Info.plist;
                    IPHONEOS_DEPLOYMENT_TARGET = 10.3;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = ucb.br.turmadobem;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    PROVISIONING_PROFILE = '';
                    PROVISIONING_PROFILE_SPECIFIER = '';
                    SWIFT_OBJC_BRIDGING_HEADER = 'ProjetoTDB/Commons/ProjetoTDB-Bridging-Header.h';
                    SWIFT_VERSION = 3.0;
                };
                name = Release;
            };
            5BB5E97E1F30F9BF0098BDD0 /* Debug */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = 783758CF29ADF5D71965397B /* Pods-ProjetoTDBTests.debug.xcconfig */;
                buildSettings = {
                    ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES = YES;
                    BUNDLE_LOADER = '$(TEST_HOST)';
                    INFOPLIST_FILE = ProjetoTDBTests / Info.plist;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks @loader_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = MauricioJunior.org.ProjetoTDBTests;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    SWIFT_VERSION = 3.0;
                    TEST_HOST = '$(BUILT_PRODUCTS_DIR)/ProjetoTDB.app/ProjetoTDB';
                };
                name = Debug;
            };
            5BB5E97F1F30F9BF0098BDD0 /* Release */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = 33F274DAE6B8BF51E012D5A0 /* Pods-ProjetoTDBTests.release.xcconfig */;
                buildSettings = {
                    ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES = YES;
                    BUNDLE_LOADER = '$(TEST_HOST)';
                    INFOPLIST_FILE = ProjetoTDBTests / Info.plist;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks @loader_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = MauricioJunior.org.ProjetoTDBTests;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    SWIFT_VERSION = 3.0;
                    TEST_HOST = '$(BUILT_PRODUCTS_DIR)/ProjetoTDB.app/ProjetoTDB';
                };
                name = Release;
            };
            5BB5E9811F30F9BF0098BDD0 /* Debug */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = EC9518955A9836A53BE8F70D /* Pods-ProjetoTDBUITests.debug.xcconfig */;
                buildSettings = {
                    ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES = YES;
                    INFOPLIST_FILE = ProjetoTDBUITests / Info.plist;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks @loader_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = MauricioJunior.org.ProjetoTDBUITests;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    SWIFT_VERSION = 3.0;
                    TEST_TARGET_NAME = ProjetoTDB;
                };
                name = Debug;
            };
            5BB5E9821F30F9BF0098BDD0 /* Release */ = {
                isa = XCBuildConfiguration;
                baseConfigurationReference = 51C96B37795CE19A47BBEA9F /* Pods-ProjetoTDBUITests.release.xcconfig */;
                buildSettings = {
                    ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES = YES;
                    INFOPLIST_FILE = ProjetoTDBUITests / Info.plist;
                    LD_RUNPATH_SEARCH_PATHS = '$(inherited) @executable_path/Frameworks @loader_path/Frameworks';
                    PRODUCT_BUNDLE_IDENTIFIER = MauricioJunior.org.ProjetoTDBUITests;
                    PRODUCT_NAME = '$(TARGET_NAME)';
                    SWIFT_VERSION = 3.0;
                    TEST_TARGET_NAME = ProjetoTDB;
                };
                name = Release;
            };
            /* End XCBuildConfiguration section */

            /* Begin XCConfigurationList section */
            5BB5E94D1F30F9BE0098BDD0 /* Build configuration list for PBXProject 'ProjetoTDB' */ = {
                isa = XCConfigurationList;
                buildConfigurations = (
                    5BB5E9781F30F9BF0098BDD0 /* Debug */,
				5BB5E9791F30F9BF0098BDD0 /* Release */,
			);
                defaultConfigurationIsVisible = 0;
                defaultConfigurationName = Release;
            };
            5BB5E97A1F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDB' */ = {
                isa = XCConfigurationList;
                buildConfigurations = (
                    5BB5E97B1F30F9BF0098BDD0 /* Debug */,
				5BB5E97C1F30F9BF0098BDD0 /* Release */,
			);
                defaultConfigurationIsVisible = 0;
                defaultConfigurationName = Release;
            };
            5BB5E97D1F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDBTests' */ = {
                isa = XCConfigurationList;
                buildConfigurations = (
                    5BB5E97E1F30F9BF0098BDD0 /* Debug */,
				5BB5E97F1F30F9BF0098BDD0 /* Release */,
			);
                defaultConfigurationIsVisible = 0;
                defaultConfigurationName = Release;
            };
            5BB5E9801F30F9BF0098BDD0 /* Build configuration list for PBXNativeTarget 'ProjetoTDBUITests' */ = {
                isa = XCConfigurationList;
                buildConfigurations = (
                    5BB5E9811F30F9BF0098BDD0 /* Debug */,
				5BB5E9821F30F9BF0098BDD0 /* Release */,
			);
                defaultConfigurationIsVisible = 0;
                defaultConfigurationName = Release;
            };
            /* End XCConfigurationList section */
        };
        rootObject = 5BB5E94A1F30F9BE0098BDD0 /* Project object */;
}
");

            return str.ToString();
        }
    }
}
