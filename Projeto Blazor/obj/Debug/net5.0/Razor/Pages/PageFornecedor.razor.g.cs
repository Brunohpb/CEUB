#pragma checksum "C:\Projetos\Sistec\Pages\PageFornecedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74fb7b1b133b47ac63f98c9c0914d7cca308561e"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistec.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projetos\Sistec\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projetos\Sistec\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projetos\Sistec\_Imports.razor"
using Sistec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projetos\Sistec\_Imports.razor"
using Sistec.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PageFornecedor")]
    public partial class PageFornecedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Cadastro de Fornecedores</h1>\r\n");
            __builder.AddMarkupContent(1, @"<ul class=""nav nav-tabs"" id=""TabPrincipal"" role=""tablist""><li class=""nav-item""><a class=""nav-link active"" id=""tabLista"" data-toggle=""tab"" href=""#Lista"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Listas Usu??rios</a></li>
    <li class=""nav-item""><a class=""nav-link"" id=""tabForm"" data-toggle=""tab"" href=""#Formulario"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Cadastrar/Alterar</a></li></ul>
");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "tab-content");
            __builder.AddAttribute(4, "id", "ContentTabLista");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tab-pane fade show active");
            __builder.AddAttribute(7, "id", "Lista");
            __builder.AddAttribute(8, "role", "tabpanel");
            __builder.AddAttribute(9, "aria-labelledby", "home-tab");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-striped");
            __builder.AddMarkupContent(12, @"<thead><tr><th></th>
                    <th>
                        Cod Fornecedor
                    </th>
                    <th>
                        Nome da Empresa
                    </th>
                    <th>
                        CNPJ
                    </th>
                    <th>
                        Telefone
                    </th>
                    <th>
                        E-mail
                    </th>
                    <th>
                        Situa????o
                    </th>
                    <th></th></tr></thead>
            ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 47 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                 foreach (Fornecedor item in Fornecedor)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                    () => SelecionarFornecedor(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<span class=\"oi oi-person\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 55 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 56 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUNOMECOMPLETO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 57 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUCNPJ

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 58 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUTELEFONE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 59 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUEMAIL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 60 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                             item.USUATIVO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                   () => ExcluirFornecedor(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "tab-pane fade");
            __builder.AddAttribute(49, "id", "Formulario");
            __builder.AddAttribute(50, "role", "tabpanel");
            __builder.AddAttribute(51, "aria-labelledby", "profile-tab");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "style", "width: 800px;padding: 40px;");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "input-group mb-3");
            __builder.AddMarkupContent(56, "<label class=\"input-group-text\" for=\"txtNome\" style=\"width:160px;\">Nome da Empresa:</label>\r\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "id", "txtNome");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                            fornecedor.USUNOMECOMPLETO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUNOMECOMPLETO = __value, fornecedor.USUNOMECOMPLETO));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "input-group mb-3");
            __builder.AddMarkupContent(66, "<label class=\"input-group-text\" for=\"txtEmail\" style=\"width:120px;\">Email:</label>\r\n                ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "id", "txtEmail");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                             fornecedor.USUEMAIL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUEMAIL = __value, fornecedor.USUEMAIL));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "input-group mb-3");
            __builder.AddMarkupContent(76, "<label class=\"input-group-text\" for=\"txtCPF\" style=\"width:120px;\">CNPJ:</label>\r\n                ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "text");
            __builder.AddAttribute(79, "id", "txtCPF");
            __builder.AddAttribute(80, "maxlength", "14");
            __builder.AddAttribute(81, "class", "form-control cnpj");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                               fornecedor.USUCNPJ

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUCNPJ = __value, fornecedor.USUCNPJ));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.AddMarkupContent(85, "<label class=\"input-group-text\" for=\"txtTelefone\" style=\"width:120px;\">Telefone:</label>\r\n                ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "text");
            __builder.AddAttribute(88, "id", "txtTelefone");
            __builder.AddAttribute(89, "class", "form-control telefone");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                         fornecedor.USUTELEFONE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUTELEFONE = __value, fornecedor.USUTELEFONE));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "input-group mb-3");
            __builder.AddMarkupContent(95, "<label class=\"input-group-text\" for=\"Login\" style=\"width:120px;\">Login:</label>\r\n                ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "id", "txtLogin");
            __builder.AddAttribute(99, "class", "form-control");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                             fornecedor.USULOGIN

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USULOGIN = __value, fornecedor.USULOGIN));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.AddMarkupContent(103, "<label class=\"input-group-text\" for=\"txtSenha\" style=\"width:120px;\">Senha:</label>\r\n                ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "password");
            __builder.AddAttribute(106, "id", "txtSenha");
            __builder.AddAttribute(107, "class", "form-control");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                 fornecedor.USUSENHA

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUSENHA = __value, fornecedor.USUSENHA));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-check");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "class", "form-check-input");
            __builder.AddAttribute(115, "type", "checkbox");
            __builder.AddAttribute(116, "id", "flexCheckDefault");
            __builder.AddAttribute(117, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                             fornecedor.USUATIVO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fornecedor.USUATIVO = __value, fornecedor.USUATIVO));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.AddMarkupContent(120, "<label class=\"form-check-label\" for=\"flexCheckDefault\">\r\n                    Ativo?\r\n                </label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "style", "text-align: center;");
            __builder.OpenElement(124, "input");
            __builder.AddAttribute(125, "type", "button");
            __builder.AddAttribute(126, "value", "Gravar");
            __builder.AddAttribute(127, "class", "btn btn-primary");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                      GravarFornecedor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "button");
            __builder.AddAttribute(132, "value", "Cancelar");
            __builder.AddAttribute(133, "class", "btn btn-warning");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                                        CancelarAcao

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n            <br>\r\n            ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "alert alert-danger");
            __builder.AddAttribute(138, "style", "display:" + " " + (
#nullable restore
#line 106 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                             MostrarMensam

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddMarkupContent(139, "<strong>Aten????o!</strong> Campos Obrigat??rio: Nome, Email, Login E Senha.\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "modal");
            __builder.AddAttribute(143, "id", "ModalExclusao");
            __builder.AddAttribute(144, "tabindex", "-1");
            __builder.AddAttribute(145, "role", "dialog");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "modal-dialog");
            __builder.AddAttribute(148, "role", "document");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "modal-content");
            __builder.AddMarkupContent(151, "<div class=\"modal-header\"><h5 class=\"modal-title\">Confirma????o</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button></div>\r\n      ");
            __builder.AddMarkupContent(152, "<div class=\"modal-body\"><p>Confirma a Exclus??o do Fornecedor</p></div>\r\n      ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "modal-footer");
            __builder.OpenElement(155, "button");
            __builder.AddAttribute(156, "type", "button");
            __builder.AddAttribute(157, "class", "btn btn-success");
            __builder.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                                ConfirmarExclusao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(159, "Sim");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n        ");
            __builder.OpenElement(161, "button");
            __builder.AddAttribute(162, "type", "button");
            __builder.AddAttribute(163, "class", "btn btn-danger");
            __builder.AddAttribute(164, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
                                                               CancelarExclusao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(165, "N??o");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n\r\n");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "modal");
            __builder.AddAttribute(169, "id", "ModalCamposObrigatorios");
            __builder.AddAttribute(170, "tabindex", "-1");
            __builder.AddAttribute(171, "role", "dialog");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "modal-dialog");
            __builder.AddAttribute(174, "role", "document");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "modal-content");
            __builder.AddMarkupContent(177, "<div class=\"modal-header\"><h5 class=\"modal-title\">Campos Obrigat??rios</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button></div>\r\n      ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "modal-body");
            __builder.OpenElement(180, "p");
            __builder.AddContent(181, 
#nullable restore
#line 145 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
            MensagemErro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n      ");
            __builder.AddMarkupContent(183, "<div class=\"modal-footer\"><button type=\"button\" class=\"btn btn-success\" data-dismiss=\"modal\">OK</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "C:\Projetos\Sistec\Pages\PageFornecedor.razor"
       

    public string MostrarMensam = "none";
    public string MensagemErro = "";
    private IList<Fornecedor> Fornecedor = new List<Fornecedor>();
    private Fornecedor fornecedor = new Fornecedor();


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            JS.InvokeAsync<string>("LoadPage", "");
            StateHasChanged();
        }
    }

    private void CarregarFornecedor()
    {
        Fornecedor = new FornecedorDAO().BuscarFornecedor();
    }

    protected override async Task OnInitializedAsync()
    {
        CarregarFornecedor();
    }

    protected async Task ExcluirFornecedor(Fornecedor usu)
    {
        JS.InvokeAsync<string>("ShowModal", "ModalExclusao");
        fornecedor  = usu;
        //new UsuarioDAO().ExcluirUsuario(usu);
        //CarregarUsuarios();
    }

    public void ConfirmarExclusao()
    {
        if(fornecedor!=null)
        {
            new FornecedorDAO().ExcluirFornecedor(fornecedor);
            CarregarFornecedor();
        }
        JS.InvokeAsync<string>("HideModal", "ModalExclusao");
        fornecedor = new Fornecedor();
    }
    public void CancelarExclusao()
    {
        fornecedor = new Fornecedor();
        JS.InvokeAsync<string>("HideModal", "ModalExclusao");
        
    }

    protected async Task SelecionarFornecedor(Fornecedor usu)
    {
        fornecedor = usu;
        JS.InvokeAsync<string>("ShowTab", "tabForm");
    }

    public void GravarFornecedor()
    {
        if (string.IsNullOrEmpty(fornecedor.USULOGIN) ||
        string.IsNullOrEmpty(fornecedor.USUEMAIL) ||
        string.IsNullOrEmpty(fornecedor.USUNOMECOMPLETO) ||
        string.IsNullOrEmpty(fornecedor.USUSENHA))
        {
            MensagemErro = "Nome, Email, Login E Senha!";
            JS.InvokeAsync<string>("ShowModal", "ModalCamposObrigatorios");
            //MostrarMensam = "block";
        }
        else
        {
             bool Validado = true;

            //Valida Email edesgomes@gmail.com
            if(!string.IsNullOrEmpty(fornecedor.USUEMAIL))
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(fornecedor.USUEMAIL);
                if (!match.Success)//=false
                {
                    MensagemErro = "Email inv??lido!";
                    JS.InvokeAsync<string>("ShowModal", "ModalCamposObrigatorios");
                    Validado  = false;
                }
            }

            if(!string.IsNullOrEmpty(fornecedor.USUCNPJ))
            {
                if(!IsCnpj(fornecedor.USUCNPJ))
                {
                    MensagemErro = "CPNJ inv??lido!";
                    JS.InvokeAsync<string>("ShowModal", "ModalCamposObrigatorios");
                    Validado  = false;
                }
            }
            
            
            if(Validado)
            {
                if (fornecedor.USUID > 0)
                {
                    new FornecedorDAO().AtualizarFornecedor(fornecedor);
                }
                else
                {
                    fornecedor.USUDATAHORACRIACAO = DateTime.Now;
                    new FornecedorDAO().InserirFornecedor(fornecedor);

                }

                fornecedor = new Fornecedor();
                CarregarFornecedor();
                MostrarMensam = "none";
                JS.InvokeAsync<string>("ShowTab", "tabLista");

            }


            
        }
    }

    public void CancelarAcao()
    {
        fornecedor = new Fornecedor();
        JS.InvokeAsync<string>("ShowTab", "tabLista");
    }


    public static bool IsCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
			if (cnpj.Length != 14)
			   return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for(int i=0; i<12; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if ( resto < 2)
			   resto = 0;
			else
			   resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
			    resto = 0;
			else
			   resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}
	

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
