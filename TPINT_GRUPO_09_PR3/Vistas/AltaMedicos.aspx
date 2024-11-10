﻿<%@ Page Title="Alta Médicos" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AltaMedicos.aspx.cs" Inherits="Vistas.AltaMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        color: #006699;
        font-weight: bold;
        font-size: x-large;
        font-family: Arial, Helvetica, sans-serif;
    }

    .auto-style2 {
        --bs-form-check-bg: var(--bs-body-bg);
        flex-shrink: 0;
        margin-top: .25em;
        vertical-align: top;
        -webkit-appearance: none;
        -moz-appearance: none;
        appearance: none;
        background-color: var(--bs-form-check-bg);
        background-image: url('var(--bs-form-check-bg-image)');
        background-repeat: no-repeat;
        background-position: center;
        background-size: contain;
        -webkit-print-color-adjust: exact;
        print-color-adjust: exact;
    }
    
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 50%; display: flex; flex-direction: column; align-items: center; justify-content: center;">
    
    <asp:Label ID="lblTitulo" runat="server" Text="Agregar Médico" CssClass="auto-style1"></asp:Label>
    
    <asp:Label ID="lblLegajo" runat="server" Text="Legajo" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtLegajo" class="form-control" runat="server" ValidationGroup="grupo1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revLegajo" runat="server" ControlToValidate="txtLegajo" ForeColor="#CC0000" ValidationExpression="^\d+$" ValidationGroup="grupo1">(*) Ingrese solo números.</asp:RegularExpressionValidator>
  
    <asp:Label ID="lblDNI" runat="server" Text="DNI" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtDNI" class="form-control" runat="server" ValidationGroup="grupo1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtDNI" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revDNI" runat="server" ControlToValidate="txtDNI" ForeColor="#CC0000" ValidationExpression="^\d+$" ValidationGroup="grupo1">(*) Ingrese solo números.</asp:RegularExpressionValidator>
    <asp:Label ID="lblMensajeDNI" runat="server" CssClass="mb-2" ForeColor="#CC0000" Text=""></asp:Label>

    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtNombre" class="form-control" runat="server" ValidationGroup="grupo1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revNombre" CssClass="mb-3" runat="server" ControlToValidate="txtNombre" ForeColor="#CC0000" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="grupo1">(*) Ingrese solo letras.</asp:RegularExpressionValidator>

    <asp:Label ID="lblApellido" runat="server" Text="Apellido" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtApellido" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revApellido" CssClass="mb-3" runat="server" ControlToValidate="txtApellido" ForeColor="#CC0000" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="grupo1">(*) Ingrese solo letras.</asp:RegularExpressionValidator>

    <asp:Label ID="lblSexo" runat="server" Text="Sexo" Style="align-self: flex-start"></asp:Label>
   
   <div class="ContenedoRadioButtonsSexo">
    <div class="form-check form-check-inline mb-4">
           <asp:RadioButton ID="rbMasculino" runat="server" GroupName="Sexo" Text="Masculino" CssClass="auto-style2" Checked="true" Width="150px" />
    </div>

    <div class="form-check form-check-inline mb-4">
        <asp:RadioButton ID="rbFemenino" runat="server" GroupName="Sexo" Text="Femenino" CssClass="auto-style2" Width="150px" />
    </div>
        <div class="form-check form-check-inline mb-4">
    <asp:RadioButton ID="rbOtro" runat="server" GroupName="Sexo" Text="Otro" CssClass="auto-style2" Width="150px" />
    </div>
    </div>

    <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtFechaNacimiento" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvFechaNacimiento" CssClass="mb-5" runat="server" ControlToValidate="txtFechaNacimiento" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>

    <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtNacionalidad" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" ControlToValidate="txtNacionalidad" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revNacionalidad" CssClass="mb-3" runat="server" ControlToValidate="txtNacionalidad" ForeColor="#CC0000" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="grupo1">(*) Ingrese solo letras.</asp:RegularExpressionValidator>


    <asp:Label ID="lblDireccion" runat="server" Text="Dirección" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtDireccion" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvDireccion" CssClass="mb-5" runat="server" ControlToValidate="txtDireccion" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>

    <asp:Label ID="lblLocalidad" runat="server" Text="Localidad" Style="align-self: flex-start"></asp:Label>
    <asp:DropDownList ID="ddlLocalidad" class="form-select" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rfvLocalidad" CssClass="mb-5" runat="server" ControlToValidate="ddlLocalidad" ForeColor="#CC0000" ValidationGroup="grupo1" InitialValue="0">(*) Seleccione una opción.</asp:RequiredFieldValidator>

    <asp:Label ID="lblProvincia" runat="server" Text="Provincia" Style="align-self: flex-start"></asp:Label>
    <asp:DropDownList ID="ddlProvincia" class="form-select" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rfvProvincia" CssClass="mb-5" runat="server" ControlToValidate="ddlProvincia" ForeColor="#CC0000" ValidationGroup="grupo1" InitialValue="0">(*) Seleccione una opción.</asp:RequiredFieldValidator>

    <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electrónico" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtCorreoElectronico" class="form-control" runat="server" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvCorreoElectronico" CssClass="mb-5" runat="server" ControlToValidate="txtCorreoElectronico" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>

    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono" Style="align-self: flex-start"></asp:Label>
    <asp:TextBox ID="txtTelefono" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="#CC0000" ValidationGroup="grupo1">(*) Complete el campo.</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="revTelefono" runat="server" ControlToValidate="txtTelefono" ForeColor="#CC0000" ValidationExpression="^\d+$" ValidationGroup="grupo1">(*) Ingrese solo números.</asp:RegularExpressionValidator>

    <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad" Style="align-self: flex-start"></asp:Label>
    <asp:DropDownList ID="ddlEspecialidad" class="form-select" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="rfvEspecialidad" CssClass="mb-5" runat="server" ControlToValidate="ddlEspecialidad" ForeColor="#CC0000" ValidationGroup="grupo1" InitialValue="0">(*) Seleccione una opción.</asp:RequiredFieldValidator>

     <asp:Button ID="btnAgregar" class="btn btn-success" runat="server" Text="Agregar" />
     <p></p>
     <button type="btnCargarHorarios" class="btn btn-primary btn-lg">Cargar días y horarios</button>

</div>
</asp:Content>