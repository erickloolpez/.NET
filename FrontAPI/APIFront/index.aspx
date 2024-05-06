<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="APIFront.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dashboard Awita | erickloolpez</title>
    <link href="./src/styles.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons+Sharp" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <header>
            <asp:TextBox ID="inputBungee" runat="server" Style="display: none"></asp:TextBox>
            <asp:TextBox ID="halfBungee" runat="server" Style="display: none"></asp:TextBox>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="APIFront.APICliente.cliente" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="ListarFiltro" TypeName="APIFront.APICliente.Api_GestionCliente" UpdateMethod="Actualizar">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="" Name="info" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="APIFront.APIPlan.planes" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="ListarFiltro" TypeName="APIFront.APIPlan.Api_GestionPlan" UpdateMethod="Actualizar">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" Name="info" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DataObjectTypeName="APIFront.APISuscripcion.suscripcion" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="ListarFiltro" TypeName="APIFront.APISuscripcion.Api_GestionSuscripcion" UpdateMethod="Actualizar">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox3" Name="info" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" DataObjectTypeName="APIFront.APIHistorial.historial_plan" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="ListarFiltro" TypeName="APIFront.APIHistorial.Api_GestionHistorial" UpdateMethod="Actualizar">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox4" Name="info" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" DataObjectTypeName="APIFront.APIFactura.factura" DeleteMethod="Eliminar" InsertMethod="Insertar" SelectMethod="ListarFiltro" TypeName="APIFront.APIFactura.Api_GestionFactura" UpdateMethod="Actualizar">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox5" Name="info" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <div class="header-content">
                <div class="header-box header-left">
                    <div class="header-info mail">
                        <div class="header-top--circle">
                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512" width="14px" height="14px"
                                fill="white">
                                <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                                <path
                                    d="M64 112c-8.8 0-16 7.2-16 16v22.1L220.5 291.7c20.7 17 50.4 17 71.1 0L464 150.1V128c0-8.8-7.2-16-16-16H64zM48 212.2V384c0 8.8 7.2 16 16 16H448c8.8 0 16-7.2 16-16V212.2L322 328.8c-38.4 31.5-93.7 31.5-132 0L48 212.2zM0 128C0 92.7 28.7 64 64 64H448c35.3 0 64 28.7 64 64V384c0 35.3-28.7 64-64 64H64c-35.3 0-64-28.7-64-64V128z" />
                            </svg>


                        </div>
                        <p>
                            awita@gmail.com
                        </p>
                    </div>
                    <div class="header-info">
                        <div class="header-top--circle">
                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 384 512" width="14px" height="14px"
                                fill="white">
                                <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                                <path
                                    d="M215.7 499.2C267 435 384 279.4 384 192C384 86 298 0 192 0S0 86 0 192c0 87.4 117 243 168.3 307.2c12.3 15.3 35.1 15.3 47.4 0zM192 128a64 64 0 1 1 0 128 64 64 0 1 1 0-128z" />
                            </svg>
                        </div>
                        <p>
                            Valle De Los Chillos
                        </p>
                    </div>
                </div>
                <div class="header-box header-right">
                    <div class="header-social">
                        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512" width="14px" height="14px"
                            fill="gray">
                            <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                            <path
                                d="M512 256C512 114.6 397.4 0 256 0S0 114.6 0 256C0 376 82.7 476.8 194.2 504.5V334.2H141.4V256h52.8V222.3c0-87.1 39.4-127.5 125-127.5c16.2 0 44.2 3.2 55.7 6.4V172c-6-.6-16.5-1-29.6-1c-42 0-58.2 15.9-58.2 57.2V256h83.6l-14.4 78.2H287V510.1C413.8 494.8 512 386.9 512 256h0z" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512" width="14px" height="14px"
                            fill="gray">
                            <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                            <path
                                d="M389.2 48h70.6L305.6 224.2 487 464H345L233.7 318.6 106.5 464H35.8L200.7 275.5 26.8 48H172.4L272.9 180.9 389.2 48zM364.4 421.8h39.1L151.1 88h-42L364.4 421.8z" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px" height="14px"
                            fill="gray">
                            <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                            <path
                                d="M416 32H31.9C14.3 32 0 46.5 0 64.3v383.4C0 465.5 14.3 480 31.9 480H416c17.6 0 32-14.5 32-32.3V64.3c0-17.8-14.4-32.3-32-32.3zM135.4 416H69V202.2h66.5V416zm-33.2-243c-21.3 0-38.5-17.3-38.5-38.5S80.9 96 102.2 96c21.2 0 38.5 17.3 38.5 38.5 0 21.3-17.2 38.5-38.5 38.5zm282.1 243h-66.4V312c0-24.8-.5-56.7-34.5-56.7-34.6 0-39.9 27-39.9 54.9V416h-66.4V202.2h63.7v29.2h.9c8.9-16.8 30.6-34.5 62.9-34.5 67.2 0 79.7 44.3 79.7 101.9V416z" />
                        </svg>
                    </div>
                    <div class="header-appointment">
                        <p>Agenda Tu Cita</p>
                    </div>

                </div>
            </div>
        </header>
        <main runat="server">
            <div runat="server" class="layout">
                <div class="main-top">
                    <div class="main-top--logo">
                        <img src="src/assets/img/awita.png" alt="logo" />
                    </div>
                    <nav>
                        <ul>
                            <li>
                                <p>Principal</p>
                            </li>
                            <li>
                                <p>Acerca de</p>
                            </li>
                            <li>
                                <p>Galeria</p>
                            </li>
                            <li>
                                <p>Paginas</p>
                            </li>
                            <li>
                                <p>Servicios</p>
                            </li>
                            <li>
                                <p>Blog</p>
                            </li>
                            <li>
                                <p>Contacto</p>
                            </li>
                        </ul>
                    </nav>
                    <div class="main-top--menu">
                        <div class="main-menu--circle">
                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="24px" height="24px"
                                fill="white">
                                <path
                                    d="M0 96C0 78.3 14.3 64 32 64H416c17.7 0 32 14.3 32 32s-14.3 32-32 32H32C14.3 128 0 113.7 0 96zM0 256c0-17.7 14.3-32 32-32H416c17.7 0 32 14.3 32 32s-14.3 32-32 32H32c-17.7 0-32-14.3-32-32zM448 416c0 17.7-14.3 32-32 32H32c-17.7 0-32-14.3-32-32s14.3-32 32-32H416c17.7 0 32 14.3 32 32z" />
                            </svg>
                        </div>
                    </div>

                </div>
                <div class="main-cover">
                    <div class="cover-main">
                        <div class="cover-h3">
                            <h1>Agua no es mas que vida.</h1>
                        </div>
                        <div class="cover-h1">
                            <h1>Agua mineral con gran sabor</h1>
                        </div>
                        <div class="cover-p">
                            <p>
                                Hidratación con estilo: porque beber agua es más que solo una necesidad, ¡es un estilo de
                            vida!... Siendo nuestra agua: la única forma de convertir '¡Tengo sed!' en '¡Qué sed tengo
                            </p>
                        </div>
                        <div class="cover-button">
                            <button>READ MORE</button>
                        </div>
                        <img id="botellon" src="src/assets/img/bottellon.png" alt="botellon" />
                    </div>
                </div>
            </div>
            <div runat="server" class="plan">
                <div class="plan-content">
                    <div class="plan-content--title">
                        <h1>Elige Tu Plan</h1>
                        <img src="src/assets/img/rayas.png" alt="rayas.png" />
                    </div>
                    <div class="plan-content--button">
                        <h3>MENSUAL</h3>
                        <input type="checkbox" id="checkButton" />
                        <label for="checkButton"></label>
                        <h3>ANUAL</h3>
                    </div>
                    <div class="plan-content--options">
                        <div class="options-content">
                            <h3>Sediento</h3>
                            <h1 class="sediento">$9</h1>
                            <p class="labelPlanS">Mensual</p>
                            <div class="options-content--line"></div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>1 Botellon</p>
                                </li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>Recarga de Botellones</p>
                                </li>
                            </ul>
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                <ContentTemplate>
                                    <button class="btnSediento btn">COMENCEMOS</button>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <p>*Prueba Gratuita de 14 Dias</p>
                        </div>
                        <div class="options-content refresh">
                            <h3>Refrescado</h3>
                            <h1 class="refrescado">$12</h1>
                            <p class="labelPlanR">Mensual</p>
                            <div class="options-content--line"></div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>3 Botellon</p>
                                </li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>Recarga de Botellones</p>
                                </li>
                            </ul>
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                <ContentTemplate>
                                    <button class="btnRefrescado btn">COMENCEMOS</button>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <p>*Prueba Gratuita de 14 Dias</p>
                        </div>
                        <div class="options-content">
                            <h3>Hidratado</h3>
                            <h1 class="hidratado">$15</h1>
                            <p class="labelPlanH">Mensual</p>
                            <div class="options-content--line"></div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>5 Botellon</p>
                                </li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="14px"
                                        height="14px" fill="#5A26E1">
                                        <path
                                            d="M438.6 105.4c12.5 12.5 12.5 32.8 0 45.3l-256 256c-12.5 12.5-32.8 12.5-45.3 0l-128-128c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0L160 338.7 393.4 105.4c12.5-12.5 32.8-12.5 45.3 0z" />
                                    </svg>
                                    <p>Recarga de Botellones</p>
                                </li>
                            </ul>
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                <ContentTemplate>
                                    <button class="btnHidratado btn">COMENCEMOS</button>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <p>
                                *Prueba Gratuita de 14 Dias
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div runat="server" class="container-aside">
                <aside>
                    <div class="toggle">
                        <div class="logo">
                            <img src="src/assets/img/awita.png" />
                        </div>
                        <div class="close" id="close-btn">
                            <span class="material-icons-sharp">close
                            </span>
                        </div>
                    </div>

                    <div class="sidebar">
                        <a href="#">
                            <span class="material-icons-sharp">dashboard
                            </span>
                            <h3>Dashboard</h3>
                        </a>
                        <a class="btnPlanes" href="#">
                            <span class="material-icons-sharp">person_outline
                            </span>
                            <h3>Planes</h3>
                        </a>
                        <a class="btnSuscripcion" href="#">
                            <span class="material-icons-sharp">receipt_long
                            </span>
                            <h3>Suscripciones</h3>
                        </a>
                        <a class="btnClientes active" href="#">
                            <span class="material-icons-sharp">insights
                            </span>
                            <h3>Clientes</h3>
                        </a>
                        <a class="btnFactura" href="#">
                            <span class="material-icons-sharp">mail_outline
                            </span>
                            <h3>Facturas</h3>
                            <span class="message-count">27</span>
                        </a>
                        <a class="btnHistorial" href="#">
                            <span class="material-icons-sharp">inventory
                            </span>
                            <h3>Facturas</h3>
                        </a>
                        <a href="#">
                            <span class="material-icons-sharp">report_gmailerrorred
                            </span>
                            <h3>Reports</h3>
                        </a>
                        <a href="#">
                            <span class="material-icons-sharp">settings
                            </span>
                            <h3>Settings</h3>
                        </a>
                        <a href="#">
                            <span class="material-icons-sharp">add
                            </span>
                            <h3>New Login</h3>
                        </a>
                        <a href="#">
                            <span class="material-icons-sharp">logout
                            </span>
                            <h3>Logout</h3>
                        </a>
                    </div>
                </aside>
                <!--<img id="discretBg" src="./Src/Assets/img/backgroundTwo.png" />-->
                <div class="container-main">
                    <!-- Analyses -->
                    <div class="analyse">
                        <div class="sales">
                            <div class="status">
                                <div class="info">
                                    <h3>Total Sales</h3>
                                    <h1>$65,024</h1>
                                </div>
                                <div class="progresss">
                                    <svg>
                                        <circle cx="38" cy="38" r="36"></circle>
                                    </svg>
                                    <div class="percentage">
                                        <p>+81%</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="visits">
                            <div class="status">
                                <div class="info">
                                    <h3>Site Visit</h3>
                                    <h1>24,981</h1>
                                </div>
                                <div class="progresss">
                                    <svg>
                                        <circle cx="38" cy="38" r="36"></circle>
                                    </svg>
                                    <div class="percentage">
                                        <p>-48%</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="searches">
                            <div class="status">
                                <div class="info">
                                    <h3>Searches</h3>
                                    <h1>14,147</h1>
                                </div>
                                <div class="progresss">
                                    <svg>
                                        <circle cx="38" cy="38" r="36"></circle>
                                    </svg>
                                    <div class="percentage">
                                        <p>+21%</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End of Analyses -->

                    <!-- New Users Section -->
                    <div class="sectionCharts">
                        <div class="containerCharts">
                            <div class="chart-container">
                                <div id="canvas-container"></div>
                            </div>
                        </div>
                        <div class="containerCharts">
                            <div class="chart-container">
                                <div id="canvas-containerTwo"></div>
                            </div>
                        </div>

                    </div>


                    <!-- End of New Users Section -->

                    <div class="table" id="clienteTable">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="updatePanel-header">
                                    <div class="updatePanel-header--divider">
                                        <h1>Busqueda de Cliente</h1>
                                        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>
                                        <span class="material-icons-sharp searchIcon">search</span>
                                    </div>
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
                                </div>
                                <div class="updatePanel-insert">
                                    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
                                        <InsertItemTemplate>
                                            id:
                                    <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                                            nombre:
                                    <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
                                            apellido:
                                    <asp:TextBox ID="apellidoTextBox" runat="server" Text='<%# Bind("apellido") %>' />
                                            email:
                                    <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                        </InsertItemTemplate>
                                    </asp:FormView>
                                </div>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowPaging="True" PageSize="20" DataKeyNames="id">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                                        <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                    <div class="table" id="planTable">
                        <asp:UpdatePanel ID="updatepanel2" runat="server">
                            <ContentTemplate>
                                <div class="updatePanel-header">
                                    <div class="updatePanel-header--divider">
                                        <h1>busqueda de planes</h1>
                                        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="true"></asp:TextBox>
                                        <span class="material-icons-sharp searchIcon">search</span>
                                    </div>
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="+" />
                                </div>
                                <div class="updatePanel-insert">
                                    <asp:FormView ID="FormView2" runat="server" DataSourceID="ObjectDataSource2">
                                        <InsertItemTemplate>
                                            id:
                                    <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                                            nombre:
                                    <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
                                            tipo:
                                    <asp:TextBox ID="tipoTextBox" runat="server" Text='<%# Bind("tipo") %>' />
                                            precio:
                                            <asp:TextBox ID="precioTextBox" runat="server" Text='<%# Bind("precio") %>' />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                        </InsertItemTemplate>
                                    </asp:FormView>
                                </div>
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" AllowPaging="True" PageSize="20" DataKeyNames="id">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                                        <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                                        <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>


                    <div class="table" id="suscripcionTable">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <div class="updatePanel-header">
                                    <div class="updatePanel-header--divider">
                                        <h1>Busqueda de Suscripcion</h1>
                                        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="true"></asp:TextBox>
                                        <span class="material-icons-sharp searchIcon">search</span>
                                    </div>
                                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
                                </div>
                                <div class="updatePanel-insert">
                                    <asp:FormView ID="FormView3" runat="server" DataSourceID="ObjectDataSource3">
                                        <InsertItemTemplate>
                                            cliente_id:
                                            <asp:TextBox ID="cliente_idTextBox" runat="server" Text='<%# Bind("cliente_id") %>' />
                                            plan_id:
                                            <asp:TextBox ID="plan_idTextBox" runat="server" Text='<%# Bind("plan_id") %>' />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                        </InsertItemTemplate>
                                    </asp:FormView>
                                </div>
                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" AllowPaging="True" PageSize="20" DataKeyNames="id">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                        <asp:BoundField DataField="cliente_id" HeaderText="cliente_id" SortExpression="cliente_id" />
                                        <asp:BoundField DataField="plan_id" HeaderText="plan_id" SortExpression="plan_id" />
                                        <asp:BoundField DataField="fecha_suscripcion" HeaderText="fecha_suscripcion" SortExpression="fecha_suscripcion" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>


                    <div class="table" id="historialTable">
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <div class="updatePanel-header">
                                    <div class="updatePanel-header--divider">
                                        <h1>Busqueda de Historial</h1>
                                        <asp:TextBox ID="TextBox4" runat="server" AutoPostBack="true"></asp:TextBox>
                                        <span class="material-icons-sharp searchIcon">search</span>
                                    </div>
                                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="+" />
                                </div>
                                <div class="updatePanel-insert">
                                    <asp:FormView ID="FormView4" runat="server" DataSourceID="ObjectDataSource4">
                                        <InsertItemTemplate>
                                            id:
                                            <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                                            suscripcion_id:
                                            <asp:TextBox ID="suscripcion_idTextBox" runat="server" Text='<%# Bind("suscripcion_id") %>' />
                                            plan_id:
                                            <asp:TextBox ID="plan_idTextBox" runat="server" Text='<%# Bind("plan_id") %>' />
                                            fecha_comienzo:
                                            <asp:TextBox ID="fecha_comienzoTextBox" runat="server" Text='<%# Bind("fecha_comienzo") %>' />
                                            fecha_final:
                                            <asp:TextBox ID="fecha_finalTextBox" runat="server" Text='<%# Bind("fecha_final") %>' />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                        </InsertItemTemplate>
                                    </asp:FormView>
                                </div>
                                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4" AllowPaging="True" PageSize="20" DataKeyNames="id">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                        <asp:BoundField DataField="suscripcion_id" HeaderText="suscripcion_id" SortExpression="suscripcion_id" />
                                        <asp:BoundField DataField="plan_id" HeaderText="plan_id" SortExpression="plan_id" />
                                        <asp:BoundField DataField="fecha_comienzo" HeaderText="fecha_comienzo" SortExpression="fecha_comienzo" />
                                        <asp:BoundField DataField="fecha_final" HeaderText="fecha_final" SortExpression="fecha_final" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>


                    <div class="table" id="facturaTable">
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <div class="updatePanel-header">
                                    <div class="updatePanel-header--divider">
                                        <h1>Busqueda de Historial</h1>
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        <span class="material-icons-sharp searchIcon">search</span>
                                    </div>
                                    <asp:Button ID="Button6" runat="server" Text="Button" />
                                </div>
                                <div class="updatePanel-insert">
                                    <asp:FormView ID="FormView5" runat="server" DataSourceID="ObjectDataSource5">
                                        <InsertItemTemplate>
                                            id:
                                    <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                                            suscripcion_id:
                                    <asp:TextBox ID="suscripcion_idTextBox" runat="server" Text='<%# Bind("suscripcion_id") %>' />
                                            plan_historial_id:
                                    <asp:TextBox ID="plan_historial_idTextBox" runat="server" Text='<%# Bind("plan_historial_id") %>' />
                                            fecha_inicio:
                                    <asp:TextBox ID="fecha_inicioTextBox" runat="server" Text='<%# Bind("fecha_inicio") %>' />
                                            fecha_final:
                                    <asp:TextBox ID="fecha_finalTextBox" runat="server" Text='<%# Bind("fecha_final") %>' />
                                            total:
                                    <asp:TextBox ID="totalTextBox" runat="server" Text='<%# Bind("total") %>' />
                                            factura_cancelada:
                                    <asp:TextBox ID="factura_canceladaTextBox" runat="server" Text='<%# Bind("factura_cancelada") %>' />
                                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                                        </InsertItemTemplate>
                                    </asp:FormView>
                                </div>
                                <asp:GridView ID="GridView5" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5" DataKeyNames="id" PageSize="20">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                                        <asp:BoundField DataField="suscripcion_id" HeaderText="suscripcion_id" SortExpression="suscripcion_id" />
                                        <asp:BoundField DataField="plan_historial_id" HeaderText="plan_historial_id" SortExpression="plan_historial_id" />
                                        <asp:BoundField DataField="fecha_inicio" HeaderText="fecha_inicio" SortExpression="fecha_inicio" />
                                        <asp:BoundField DataField="fecha_final" HeaderText="fecha_final" SortExpression="fecha_final" />
                                        <asp:BoundField DataField="total" HeaderText="total" SortExpression="total" />
                                        <asp:BoundField DataField="factura_cancelada" HeaderText="factura_cancelada" SortExpression="factura_cancelada" />
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                    <!-- Recent Orders Table 
                <div class="table" id="customers_table">
                    <section class="table__header">
                        <h1>Customer's Orders</h1>
                        <div class="input-group">
                            <input type="search" placeholder="Search Data...">
                            <span class="material-icons-sharp">search
                            </span>
                        </div>
                        <div class="export__file">
                            <label for="export-file" class="export__file-btn" title="Export File"></label>
                            <input type="checkbox" id="export-file">
                            <div class="export__file-options">
                                <label>Export As &nbsp; &#10140;</label>
                                <label for="export-file" id="toPDF">
                                    PDF
                                    <img src="images/pdf.png" alt=""></label>
                                <label for="export-file" id="toJSON">
                                    JSON
                                    <img src="images/json.png" alt=""></label>
                                <label for="export-file" id="toCSV">
                                    CSV
                                    <img src="images/csv.png" alt=""></label>
                                <label for="export-file" id="toEXCEL">
                                    EXCEL
                                    <img src="images/excel.png" alt=""></label>
                            </div>
                        </div>
                    </section>
                    <section class="table__body">
                        <table>
                            <thead>
                                <tr>
                                    <th>Id <span class="icon-arrow">&UpArrow;</span></th>
                                    <th>Customer <span class="icon-arrow">&UpArrow;</span></th>
                                    <th>Location <span class="icon-arrow">&UpArrow;</span></th>
                                    <th>Order Date <span class="icon-arrow">&UpArrow;</span></th>
                                    <th>Status <span class="icon-arrow">&UpArrow;</span></th>
                                    <th>Amount <span class="icon-arrow">&UpArrow;</span></th>
                                </tr>
                            </thead>
                            <tbody runat="server" id="startTable">
                            </tbody>
                        </table>
                    </section>
                </div>-->
                    <!-- End of Recent Orders -->

                </div>
            </div>
            <div class="payment">
                <div class="nav-two">
                    <div class="nav-two--logo">
                        <img src="src/assets/img/awita.png" alt="logo" id="navTwo-logo" />
                    </div>
                    <nav>
                        <ul>
                            <li>
                                <p>Principal</p>
                            </li>
                            <li>
                                <p>Acerca de</p>
                            </li>
                            <li>
                                <p>Galeria</p>
                            </li>
                            <li>
                                <p>Paginas</p>
                            </li>
                            <li>
                                <p>Servicios</p>
                            </li>
                            <li>
                                <p>Blog</p>
                            </li>
                            <li>
                                <p>Contacto</p>
                            </li>
                        </ul>
                    </nav>
                    <div class="nav-two--menu">
                        <div class="main-menu--circle">
                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 448 512" width="24px" height="24px"
                                fill="white">
                                <path
                                    d="M0 96C0 78.3 14.3 64 32 64H416c17.7 0 32 14.3 32 32s-14.3 32-32 32H32C14.3 128 0 113.7 0 96zM0 256c0-17.7 14.3-32 32-32H416c17.7 0 32 14.3 32 32s-14.3 32-32 32H32c-17.7 0-32-14.3-32-32zM448 416c0 17.7-14.3 32-32 32H32c-17.7 0-32-14.3-32-32s14.3-32 32-32H416c17.7 0 32 14.3 32 32z" />
                            </svg>
                        </div>
                    </div>

                </div>
                <div class="payment-container">
                    <div class="payment-img">
                        <img src="src/assets/img/contact-img2.png" alt="contact" />
                    </div>
                    <div class="payment-invoice">
                        <h1>Genera tu Factura</h1>
                        <p class="payment-info"></p>
                        <div class="payment-invoice--container">
                            <div class="payment-invoice--name">
                                <input id="nombreCliente" type="text" placeholder="Nombre" runat="server" />
                                <input id="apellidoCliente" type="text" placeholder="Apellido" runat="server" />
                            </div>
                            <div class="payment-invoice--info">
                                <input id="emailCliente" type="email" placeholder="Email" runat="server" />
                                <input id="telefonoCliente" type="text" placeholder="Telefono" />
                            </div>
                        </div>
                        <input id="inputCI" class="inputCI" type="text" placeholder="CI" runat="server" />
                        <asp:TextBox ID="TextBoxPlanID" runat="server" Style="display: none"></asp:TextBox>
                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Enviar" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                </div>
            </div>
            <footer class="footer">
                <div class="footer-description">
                    <img src="src/assets/img/awita.png" alt="logo-awita" />
                    <p>Ser la principal plataforma de membresías de AWA reconocida a nivel mundial, brindando un servicio inigualable que mejora la calidad de vida de nuestros miembros.</p>
                    <div class="footer-description--icons">
                        <div class="icons-footer">
                            <svg xmlns="http://www.w3.org/2000/svg" width="14px" height="14px" fill="white"
                                viewBox="0 0 512 512">
                                <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                                <path
                                    d="M512 256C512 114.6 397.4 0 256 0S0 114.6 0 256C0 376 82.7 476.8 194.2 504.5V334.2H141.4V256h52.8V222.3c0-87.1 39.4-127.5 125-127.5c16.2 0 44.2 3.2 55.7 6.4V172c-6-.6-16.5-1-29.6-1c-42 0-58.2 15.9-58.2 57.2V256h83.6l-14.4 78.2H287V510.1C413.8 494.8 512 386.9 512 256h0z" />
                            </svg>
                        </div>
                        <div class="icons-footer">
                            <svg xmlns="http://www.w3.org/2000/svg" width="14px" height="14px" fill="white"
                                viewBox="0 0 512 512">
                                <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                                <path
                                    d="M389.2 48h70.6L305.6 224.2 487 464H345L233.7 318.6 106.5 464H35.8L200.7 275.5 26.8 48H172.4L272.9 180.9 389.2 48zM364.4 421.8h39.1L151.1 88h-42L364.4 421.8z" />
                            </svg>
                        </div>
                        <div class="icons-footer">
                            <svg xmlns="http://www.w3.org/2000/svg" width="14px" height="14px" fill="white"
                                viewBox="0 0 448 512">
                                <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
                                <path
                                    d="M416 32H31.9C14.3 32 0 46.5 0 64.3v383.4C0 465.5 14.3 480 31.9 480H416c17.6 0 32-14.5 32-32.3V64.3c0-17.8-14.4-32.3-32-32.3zM135.4 416H69V202.2h66.5V416zm-33.2-243c-21.3 0-38.5-17.3-38.5-38.5S80.9 96 102.2 96c21.2 0 38.5 17.3 38.5 38.5 0 21.3-17.2 38.5-38.5 38.5zm282.1 243h-66.4V312c0-24.8-.5-56.7-34.5-56.7-34.6 0-39.9 27-39.9 54.9V416h-66.4V202.2h63.7v29.2h.9c8.9-16.8 30.6-34.5 62.9-34.5 67.2 0 79.7 44.3 79.7 101.9V416z" />
                            </svg>
                        </div>
                    </div>
                </div>
                <div class="footer-list">
                    <div class="footer-list--content">
                        <h2>Nuestros Links</h2>
                        <ul>
                            <li>
                                <a href="#">Home</a>
                            </li>
                            <li>
                                <a href="#">Acerca de</a>
                            </li>
                            <li>
                                <a href="#">Servicios</a>
                            </li>
                            <li>
                                <a href="#">Blog</a>
                            </li>
                            <li>
                                <a href="#"></a>
                            </li>
                        </ul>
                    </div>
                    <div class="footer-list--content ">
                        <h2>Nuestros Servicios</h2>
                        <ul>
                            <li>
                                <a href="#">FAQ</a>
                            </li>
                            <li>
                                <a href="#">Soporte</a>
                            </li>
                            <li>
                                <a href="#">Privacidad</a>
                            </li>
                            <li>
                                <a href="#">Terminos & Condiciones</a>
                            </li>
                        </ul>
                    </div>
                    <div class="footer-list--content">
                        <h2>Nuestros Links</h2>
                        <ul>
                            <li>
                                <a href="#">Home</a>
                            </li>
                            <li>
                                <a href="#">Acerca de</a>
                            </li>
                            <li>
                                <a href="#">Servicios</a>
                            </li>
                            <li>
                                <a href="#">Blog</a>
                            </li>
                            <li>
                                <a href="#"></a>
                            </li>
                        </ul>
                    </div>

                </div>

            </footer>
        </main>


    </form>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@4.4.1/dist/chart.umd.min.js"></script>
    <script src="./src/lool.js"></script>
    <script src="./src/main.js"></script>
    <script src="./src/navigation.js"></script>
</body>
</html>
