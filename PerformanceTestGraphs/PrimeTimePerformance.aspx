<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimeTimePerformance.aspx.cs" Inherits="PerformanceTestGraphs.PrimeTimePerformance" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/TrialDivisionPerformance.js" type="text/javascript"></script>
    <script src="Scripts/jquery.flot.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui-1.8.17.custom.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">  
        
        <input id="btnTD" type="button" value="Trial Division" />
        <input id="btnSOE" type="button" value="Sieve of Erathosthenes" />

        <div id="placeholder" style="width:600px;height:300px"></div>        

        <asp:ScriptManager ID="_scriptManager" runat="server">
            <Services>                
                <asp:ServiceReference Path="~/TrialDivision.svc" />
                <asp:ServiceReference Path="~/SieveOfErathosthenes.svc" />
            </Services>
        </asp:ScriptManager>
    </form>   
</body>
</html>
