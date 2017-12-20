﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateHash.sourceText
{
    public static class WebApi
    {
        ///
        public static string meuTexto()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"<?xml version='1.0' encoding='utf - 8'?>
< Project ToolsVersion = '14.0' DefaultTargets = 'Build' xmlns = 'http://schemas.microsoft.com/developer/msbuild/2003' >
  < Import Project = '..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props' Condition = 'Exists('..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props')' />
  < Import Project = '..\packages\Microsoft.Net.Compilers.1.0.0\build\Microsoft.Net.Compilers.props' Condition = 'Exists('..\packages\Microsoft.Net.Compilers.1.0.0\build\Microsoft.Net.Compilers.props')' />
  < Import Project = '$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props' Condition = 'Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')' />
  < PropertyGroup >
    < Configuration Condition = ' '$(Configuration)' == '' ' > Debug </ Configuration >
    < Platform Condition = ' '$(Platform)' == '' ' > AnyCPU </ Platform >
    < ProductVersion >
    </ ProductVersion >
    < SchemaVersion > 2.0 </ SchemaVersion >
    < ProjectGuid >{ 66A57D9A - A10D - 43CF - AE22 - 7D78D819DA2C}</ ProjectGuid >
           
               < ProjectTypeGuids >{ 349c5851 - 65df - 11da - 9384 - 00065b846f21};
            { fae04ec0 - 301f - 11d3 - bf4b - 00c04f79efbc}</ ProjectTypeGuids >

< OutputType > Library </ OutputType >

< AppDesignerFolder > Properties </ AppDesignerFolder >

< RootNamespace > TDB </ RootNamespace >

< AssemblyName > TDB </ AssemblyName >

< TargetFrameworkVersion > v4.5.2 </ TargetFrameworkVersion >

< MvcBuildViews > false </ MvcBuildViews >

< UseIISExpress > true </ UseIISExpress >

< IISExpressSSLPort />

< IISExpressAnonymousAuthentication />

< IISExpressWindowsAuthentication />

< IISExpressUseClassicPipelineMode />

< UseGlobalApplicationHostFile />

< NuGetPackageImportStamp >

</ NuGetPackageImportStamp >

< ApplicationInsightsResourceId >/ subscriptions / b31d1869 - 5351 - 47ec - b7b1 - 4660a94c7ef1 / resourcegroups / Default - ApplicationInsights - EastUS / providers / microsoft.insights / components / TDB </ ApplicationInsightsResourceId >

< SccProjectName > SAK </ SccProjectName >

< SccLocalPath > SAK </ SccLocalPath >

< SccAuxPath > SAK </ SccAuxPath >

< SccProvider > SAK </ SccProvider >

</ PropertyGroup >

< PropertyGroup Condition = ' '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ' >

< DebugSymbols > true </ DebugSymbols >

< DebugType > full </ DebugType >

< Optimize > false </ Optimize >

< OutputPath > bin\</ OutputPath >

< DefineConstants > DEBUG; TRACE </ DefineConstants >

< ErrorReport > prompt </ ErrorReport >

< WarningLevel > 4 </ WarningLevel >

</ PropertyGroup >

< PropertyGroup Condition = ' '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ' >

< DebugType > pdbonly </ DebugType >

< Optimize > true </ Optimize >

< OutputPath > bin\</ OutputPath >

< DefineConstants > TRACE </ DefineConstants >

< ErrorReport > prompt </ ErrorReport >

< WarningLevel > 4 </ WarningLevel >

</ PropertyGroup >

< ItemGroup >

< Reference Include = 'Microsoft.AI.Agent.Intercept, Version=2.0.6.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >

< HintPath >..\packages\Microsoft.ApplicationInsights.Agent.Intercept.2.0.6\lib\net45\Microsoft.AI.Agent.Intercept.dll </ HintPath >

< Private > True </ Private >

</ Reference >

< Reference Include = 'Microsoft.AI.DependencyCollector, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >

< HintPath >..\packages\Microsoft.ApplicationInsights.DependencyCollector.2.2.0\lib\net45\Microsoft.AI.DependencyCollector.dll </ HintPath >

< Private > True </ Private >

</ Reference >

< Reference Include = 'Microsoft.AI.PerfCounterCollector, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >

 < HintPath >..\packages\Microsoft.ApplicationInsights.PerfCounterCollector.2.2.0\lib\net45\Microsoft.AI.PerfCounterCollector.dll </ HintPath >

   < Private > True </ Private >

 </ Reference >

 < Reference Include = 'Microsoft.AI.ServerTelemetryChannel, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >

    < HintPath >..\packages\Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel.2.2.0\lib\net45\Microsoft.AI.ServerTelemetryChannel.dll </ HintPath >
      < Private > True </ Private >
    </ Reference >
    < Reference Include = 'Microsoft.AI.Web, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
 
       < HintPath >..\packages\Microsoft.ApplicationInsights.Web.2.2.0\lib\net45\Microsoft.AI.Web.dll </ HintPath >
   
         < Private > True </ Private >
   
       </ Reference >
   
       < Reference Include = 'Microsoft.AI.WindowsServer, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
    
          < HintPath >..\packages\Microsoft.ApplicationInsights.WindowsServer.2.2.0\lib\net45\Microsoft.AI.WindowsServer.dll </ HintPath >
      
            < Private > True </ Private >
      
          </ Reference >
      
          < Reference Include = 'Microsoft.ApplicationInsights, Version=2.2.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
       
             < HintPath >..\packages\Microsoft.ApplicationInsights.2.2.0\lib\net45\Microsoft.ApplicationInsights.dll </ HintPath >
         
               < Private > True </ Private >
         
             </ Reference >
         
             < Reference Include = 'Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
          
                < HintPath >..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0\lib\net45\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll </ HintPath >
            
                  < Private > True </ Private >
            
                </ Reference >
            
                < Reference Include = 'Microsoft.CSharp' />
             
                 < Reference Include = 'System' />
              
                  < Reference Include = 'System.Data' />
               
                   < Reference Include = 'System.Drawing' />
                
                    < Reference Include = 'System.Web.Entity' />
                 
                     < Reference Include = 'System.Web.ApplicationServices' />
                  
                      < Reference Include = 'System.ComponentModel.DataAnnotations' />
                   
                       < Reference Include = 'System.Core' />
                    
                        < Reference Include = 'System.Data.DataSetExtensions' />
                     
                         < Reference Include = 'System.Xml.Linq' />
                      
                          < Reference Include = 'System.Web' />
                       
                           < Reference Include = 'System.Web.Abstractions' />
                        
                            < Reference Include = 'System.Web.Routing' />
                         
                             < Reference Include = 'System.Xml' />
                          
                              < Reference Include = 'System.Configuration' />
                           
                               < Reference Include = 'System.Runtime.Serialization' />
                            
                                < Reference Include = 'Microsoft.Web.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                             
                                   < Private > True </ Private >
                             
                                   < HintPath >..\packages\Microsoft.Web.Infrastructure.1.0.0.0\lib\net40\Microsoft.Web.Infrastructure.dll </ HintPath >
                               
                                   </ Reference >
                               
                                   < Reference Include = 'Newtonsoft.Json' >
                                
                                      < HintPath >..\packages\Newtonsoft.Json.6.0.4\lib\net45\Newtonsoft.Json.dll </ HintPath >
                                  
                                      </ Reference >
                                  
                                      < Reference Include = 'System.Net.Http' >
                                   
                                       </ Reference >
                                   
                                       < Reference Include = 'System.Net.Http.Formatting, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                    
                                          < HintPath >..\packages\Microsoft.AspNet.WebApi.Client.5.2.3\lib\net45\System.Net.Http.Formatting.dll </ HintPath >
                                      
                                          </ Reference >
                                      
                                          < Reference Include = 'System.Net.Http.WebRequest' >
                                       
                                           </ Reference >
                                       
                                           < Reference Include = 'System.Web.Helpers, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                        
                                              < Private > True </ Private >
                                        
                                              < HintPath >..\packages\Microsoft.AspNet.WebPages.3.2.3\lib\net45\System.Web.Helpers.dll </ HintPath >
                                          
                                              </ Reference >
                                          
                                              < Reference Include = 'System.Web.Http, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                           
                                                 < HintPath >..\packages\Microsoft.AspNet.WebApi.Core.5.2.3\lib\net45\System.Web.Http.dll </ HintPath >
                                             
                                                 </ Reference >
                                             
                                                 < Reference Include = 'System.Web.Http.WebHost, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                              
                                                    < HintPath >..\packages\Microsoft.AspNet.WebApi.WebHost.5.2.3\lib\net45\System.Web.Http.WebHost.dll </ HintPath >
                                                
                                                    </ Reference >
                                                
                                                    < Reference Include = 'System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                                 
                                                       < Private > True </ Private >
                                                 
                                                       < HintPath >..\packages\Microsoft.AspNet.Mvc.5.2.3\lib\net45\System.Web.Mvc.dll </ HintPath >
                                                   
                                                       </ Reference >
                                                   
                                                       < Reference Include = 'System.Web.Optimization' >
                                                    
                                                          < HintPath >..\packages\Microsoft.AspNet.Web.Optimization.1.1.3\lib\net40\System.Web.Optimization.dll </ HintPath >
                                                      
                                                          </ Reference >
                                                      
                                                          < Reference Include = 'System.Web.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                                       
                                                             < Private > True </ Private >
                                                       
                                                             < HintPath >..\packages\Microsoft.AspNet.Razor.3.2.3\lib\net45\System.Web.Razor.dll </ HintPath >
                                                         
                                                             </ Reference >
                                                         
                                                             < Reference Include = 'System.Web.WebPages, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                                          
                                                                < Private > True </ Private >
                                                          
                                                                < HintPath >..\packages\Microsoft.AspNet.WebPages.3.2.3\lib\net45\System.Web.WebPages.dll </ HintPath >
                                                            
                                                                </ Reference >
                                                            
                                                                < Reference Include = 'System.Web.WebPages.Deployment, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                                             
                                                                   < Private > True </ Private >
                                                             
                                                                   < HintPath >..\packages\Microsoft.AspNet.WebPages.3.2.3\lib\net45\System.Web.WebPages.Deployment.dll </ HintPath >
                                                               
                                                                   </ Reference >
                                                               
                                                                   < Reference Include = 'System.Web.WebPages.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL' >
                                                                
                                                                      < Private > True </ Private >
                                                                
                                                                      < HintPath >..\packages\Microsoft.AspNet.WebPages.3.2.3\lib\net45\System.Web.WebPages.Razor.dll </ HintPath >
                                                                  
                                                                      </ Reference >
                                                                  
                                                                      < Reference Include = 'WebGrease' >
                                                                   
                                                                         < Private > True </ Private >
                                                                   
                                                                         < HintPath >..\packages\WebGrease.1.5.2\lib\WebGrease.dll </ HintPath >
                                                                     
                                                                         </ Reference >
                                                                     
                                                                         < Reference Include = 'Antlr3.Runtime' >
                                                                      
                                                                            < Private > True </ Private >
                                                                      
                                                                            < HintPath >..\packages\Antlr.3.4.1.9004\lib\Antlr3.Runtime.dll </ HintPath >
                                                                        
                                                                            </ Reference >
                                                                        
                                                                          </ ItemGroup >
                                                                        
                                                                          < ItemGroup >
                                                                        
                                                                            < Reference Include = 'EntityFramework' >
                                                                         
                                                                               < HintPath >..\packages\EntityFramework.6.1.3\lib\net45\EntityFramework.dll </ HintPath >
                                                                           
                                                                               </ Reference >
                                                                           
                                                                               < Reference Include = 'EntityFramework.SqlServer' >
                                                                            
                                                                                  < HintPath >..\packages\EntityFramework.6.1.3\lib\net45\EntityFramework.SqlServer.dll </ HintPath >
                                                                              
                                                                                  </ Reference >
                                                                              
                                                                                  < Reference Include = 'Microsoft.AspNet.Identity.Core' >
                                                                               
                                                                                     < HintPath >..\packages\Microsoft.AspNet.Identity.Core.2.2.1\lib\net45\Microsoft.AspNet.Identity.Core.dll </ HintPath >
                                                                                 
                                                                                     </ Reference >
                                                                                 
                                                                                     < Reference Include = 'Microsoft.AspNet.Identity.Owin' >
                                                                                  
                                                                                        < HintPath >..\packages\Microsoft.AspNet.Identity.Owin.2.2.1\lib\net45\Microsoft.AspNet.Identity.Owin.dll </ HintPath >
                                                                                    
                                                                                        </ Reference >
                                                                                    
                                                                                        < Reference Include = 'Microsoft.AspNet.Identity.EntityFramework' >
                                                                                     
                                                                                           < HintPath >..\packages\Microsoft.AspNet.Identity.EntityFramework.2.2.1\lib\net45\Microsoft.AspNet.Identity.EntityFramework.dll </ HintPath >
                                                                                       
                                                                                           </ Reference >
                                                                                       
                                                                                           < Reference Include = 'Owin' >
                                                                                        
                                                                                              < HintPath >..\packages\Owin.1.0\lib\net40\Owin.dll </ HintPath >
                                                                                          
                                                                                              </ Reference >
                                                                                          
                                                                                              < Reference Include = 'Microsoft.Owin' >
                                                                                           
                                                                                                 < HintPath >..\packages\Microsoft.Owin.3.0.1\lib\net45\Microsoft.Owin.dll </ HintPath >
                                                                                             
                                                                                                 </ Reference >
                                                                                             
                                                                                                 < Reference Include = 'Microsoft.Owin.Host.SystemWeb' >
                                                                                              
                                                                                                    < HintPath >..\packages\Microsoft.Owin.Host.SystemWeb.3.0.1\lib\net45\Microsoft.Owin.Host.SystemWeb.dll </ HintPath >
                                                                                                
                                                                                                    </ Reference >
                                                                                                
                                                                                                    < Reference Include = 'Microsoft.Owin.Security' >
                                                                                                 
                                                                                                       < HintPath >..\packages\Microsoft.Owin.Security.3.0.1\lib\net45\Microsoft.Owin.Security.dll </ HintPath >
                                                                                                   
                                                                                                       </ Reference >
                                                                                                   
                                                                                                       < Reference Include = 'Microsoft.Owin.Security.Facebook' >
                                                                                                    
                                                                                                          < HintPath >..\packages\Microsoft.Owin.Security.Facebook.3.0.1\lib\net45\Microsoft.Owin.Security.Facebook.dll </ HintPath >
                                                                                                      
                                                                                                          </ Reference >
                                                                                                      
                                                                                                          < Reference Include = 'Microsoft.Owin.Security.Cookies' >
                                                                                                       
                                                                                                             < HintPath >..\packages\Microsoft.Owin.Security.Cookies.3.0.1\lib\net45\Microsoft.Owin.Security.Cookies.dll </ HintPath >
                                                                                                         
                                                                                                             </ Reference >
                                                                                                         
                                                                                                             < Reference Include = 'Microsoft.Owin.Security.OAuth' >
                                                                                                          
                                                                                                                < HintPath >..\packages\Microsoft.Owin.Security.OAuth.3.0.1\lib\net45\Microsoft.Owin.Security.OAuth.dll</HintPath>
    </Reference>
    <Reference Include='Microsoft.Owin.Security.Google'>
      <HintPath>..\packages\Microsoft.Owin.Security.Google.3.0.1\lib\net45\Microsoft.Owin.Security.Google.dll</HintPath>
    </Reference>
    <Reference Include='Microsoft.Owin.Security.Twitter'>
      <HintPath>..\packages\Microsoft.Owin.Security.Twitter.3.0.1\lib\net45\Microsoft.Owin.Security.Twitter.dll</HintPath>
    </Reference>
    <Reference Include='Microsoft.Owin.Security.MicrosoftAccount'>
      <HintPath>..\packages\Microsoft.Owin.Security.MicrosoftAccount.3.0.1\lib\net45\Microsoft.Owin.Security.MicrosoftAccount.dll</HintPath>
    </Reference>
    <Reference Include='System.Web.Http.Owin'>
      <HintPath>..\packages\Microsoft.AspNet.WebApi.Owin.5.2.3\lib\net45\System.Web.Http.Owin.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include='App_Start\BundleConfig.cs' />
    <Compile Include='App_Start\FilterConfig.cs' />
    <Compile Include='App_Start\IdentityConfig.cs' />
    <Compile Include='App_Start\RouteConfig.cs' />
    <Compile Include='App_Start\Startup.Auth.cs' />
    <Compile Include='App_Start\WebApiConfig.cs' />
    <Compile Include='Areas\HelpPage\ApiDescriptionExtensions.cs' />
    <Compile Include='Areas\HelpPage\App_Start\HelpPageConfig.cs' />
    <Compile Include='Areas\HelpPage\Controllers\HelpController.cs' />
    <Compile Include='Areas\HelpPage\HelpPageAreaRegistration.cs' />
    <Compile Include='Areas\HelpPage\HelpPageConfigurationExtensions.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\CollectionModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ComplexTypeModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\DictionaryModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\EnumTypeModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\EnumValueDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\IModelDocumentationProvider.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\KeyValuePairModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ModelDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ModelDescriptionGenerator.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ModelNameAttribute.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ModelNameHelper.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ParameterAnnotation.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\ParameterDescription.cs' />
    <Compile Include='Areas\HelpPage\ModelDescriptions\SimpleTypeModelDescription.cs' />
    <Compile Include='Areas\HelpPage\Models\HelpPageApiModel.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\HelpPageSampleGenerator.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\HelpPageSampleKey.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\ImageSample.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\InvalidSample.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\ObjectGenerator.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\SampleDirection.cs' />
    <Compile Include='Areas\HelpPage\SampleGeneration\TextSample.cs' />
    <Compile Include='Areas\HelpPage\XmlDocumentationProvider.cs' />
    <Compile Include='Controllers\AccountController.cs' />
    <Compile Include='Controllers\AlunoController.cs' />
    <Compile Include='Controllers\ConsideracaoController.cs' />
    <Compile Include='Controllers\DocumentoController.cs' />
    <Compile Include='Controllers\EventoController.cs' />
    <Compile Include='Controllers\FotoController.cs' />
    <Compile Include='Controllers\HomeController.cs' />
    <Compile Include='Controllers\IHCController.cs' />
    <Compile Include='Controllers\InstituicaoController.cs' />
    <Compile Include='Controllers\PercepcaoController.cs' />
    <Compile Include='Controllers\PerguntasSocioEconomicasController.cs' />
    <Compile Include='Controllers\ResponsavelController.cs' />
    <Compile Include='Controllers\TipoFotoController.cs' />
    <Compile Include='Controllers\UsuarioController.cs' />
    <Compile Include='Controllers\ValuesController.cs' />
    <Compile Include='DAO\MinhaConexao.cs' />
    <Compile Include='Global.asax.cs'>
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include='Models\AccountBindingModels.cs' />
    <Compile Include='Models\AccountViewModels.cs' />
    <Compile Include='Models\AlunoPersonalizadoTDB.cs' />
    <Compile Include='Models\AlunoTDB.cs' />
    <Compile Include='Models\ConsideracaoTDB.cs' />
    <Compile Include='Models\DocumentoTDB.cs' />
    <Compile Include='Models\EventoTDB.cs' />
    <Compile Include='Models\FotoTDB.cs' />
    <Compile Include='Models\IdentityModels.cs' />
    <Compile Include='Models\IHCTDB.cs' />
    <Compile Include='Models\InstituicaoTDB.cs' />
    <Compile Include='Models\PercepcaoTDB.cs' />
    <Compile Include='Models\PerguntasSocioEconomicasTDB.cs' />
    <Compile Include='Models\ResponsavelTDB.cs' />
    <Compile Include='Models\TipoFotoTDB.cs' />
    <Compile Include='Models\UsuarioTDB.cs' />
    <Compile Include='Properties\AssemblyInfo.cs' />
    <Compile Include='Providers\ApplicationOAuthProvider.cs' />
    <Compile Include='Results\ChallengeResult.cs' />
    <Compile Include='Startup.cs' />
  </ItemGroup>
  <ItemGroup>
    <Content Include='Areas\HelpPage\HelpPage.css' />
    <Content Include='Content\bootstrap.css' />
    <Content Include='Content\bootstrap.min.css' />
    <Content Include='favicon.ico' />
    <Content Include='fonts\glyphicons-halflings-regular.svg' />
    <Content Include='Global.asax' />
    <Content Include='Scripts\bootstrap.js' />
    <Content Include='Scripts\bootstrap.min.js' />
    <Content Include='Areas\HelpPage\Views\Web.config' />
    <Content Include='Areas\HelpPage\Views\Shared\_Layout.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\ResourceModel.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\Index.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\TextSample.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\SimpleTypeModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\Samples.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\Parameters.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\ModelDescriptionLink.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\KeyValuePairModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\InvalidSample.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\ImageSample.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\HelpPageApiModel.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\EnumTypeModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\DictionaryModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\ComplexTypeModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\DisplayTemplates\ApiGroup.cshtml' />
    <Content Include='Areas\HelpPage\Views\Help\Api.cshtml' />
    <Content Include='ApplicationInsights.config'>
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
    <None Include='Properties\PublishProfiles\FTP.pubxml' />
    <None Include='Properties\PublishProfiles\turmadobem - FTP.pubxml' />
    <None Include='Properties\PublishProfiles\turmadobem - Web Deploy.pubxml' />
    <None Include='Scripts\jquery-1.10.2.intellisense.js' />
    <Content Include='Scripts\jquery-1.10.2.js' />
    <Content Include='Scripts\jquery-1.10.2.min.js' />
    <None Include='Scripts\jquery.validate-vsdoc.js' />
    <Content Include='Scripts\jquery.validate.js' />
    <Content Include='Scripts\jquery.validate.min.js' />
    <Content Include='Scripts\jquery.validate.unobtrusive.js' />
    <Content Include='Scripts\jquery.validate.unobtrusive.min.js' />
    <Content Include='Scripts\modernizr-2.6.2.js' />
    <Content Include='Scripts\respond.js' />
    <Content Include='Scripts\respond.min.js' />
    <Content Include='Web.config' />
    <Content Include='Web.Debug.config'>
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include='Web.Release.config'>
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include='Areas\HelpPage\Views\_ViewStart.cshtml' />
    <Content Include='Content\Site.css' />
    <Content Include='Scripts\_references.js' />
    <Content Include='Views\Web.config' />
    <Content Include='Views\_ViewStart.cshtml' />
    <Content Include='Views\Home\Index.cshtml' />
    <Content Include='Views\Shared\Error.cshtml' />
    <Content Include='Views\Shared\_Layout.cshtml' />
    <Content Include='Service References\Application Insights\ConnectedService.json' />
  </ItemGroup>
  <ItemGroup>
    <Folder Include='App_Data\' />
  </ItemGroup>
  <ItemGroup>
    <Content Include='fonts\glyphicons-halflings-regular.woff' />
    <Content Include='fonts\glyphicons-halflings-regular.ttf' />
    <Content Include='fonts\glyphicons-halflings-regular.eot' />
    <Content Include='packages.config' />
    <None Include='Project_Readme.html' />
    <Content Include='Scripts\jquery-1.10.2.min.map' />
  </ItemGroup>
  <ItemGroup>
    <WCFMetadata Include='Service References\' />
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition=''$(VisualStudioVersion)' == '''>10.0</VisualStudioVersion>
    <VSToolsPath Condition=''$(VSToolsPath)' == '''>$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project='$(MSBuildBinPath)\Microsoft.CSharp.targets' />
  <Import Project='$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets' Condition=''$(VSToolsPath)' != ''' />
  <Import Project='$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets' Condition='false' />
  <Target Name='MvcBuildViews' AfterTargets='AfterBuild' Condition=''$(MvcBuildViews)'=='true''>
    <AspNetCompiler VirtualPath='temp' PhysicalPath='$(WebProjectOutputDir)' />
  </Target>
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID='{349c5851-65df-11da-9384-00065b846f21}'>
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>50283</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:50283/</IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <Target Name='EnsureNuGetPackageBuildImports' BeforeTargets='PrepareForBuild'>
    <PropertyGroup>
      <ErrorText>This project references NuGet package(s) that are missing on this computer. Use NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>
    </PropertyGroup>
    <Error Condition='!Exists('..\packages\Microsoft.Net.Compilers.1.0.0\build\Microsoft.Net.Compilers.props')' Text='$([System.String]::Format('$(ErrorText)', '..\packages\Microsoft.Net.Compilers.1.0.0\build\Microsoft.Net.Compilers.props'))' />
    <Error Condition='!Exists('..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props')' Text='$([System.String]::Format('$(ErrorText)', '..\packages\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.1.0.0\build\Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props'))' />
  </Target>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it.
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name='BeforeBuild'>
  </Target>
  <Target Name='AfterBuild'>
  </Target> -->
</Project>");

            return str.ToString();
        }
    }
}
