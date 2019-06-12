<!-- directives -->
<% @Page Language="C#" %>

<!-- code section -->
<script runat="server">

    private void convertoupper(object sender, EventArgs e)
    {
        string str = mytext.Value;
        changed_text.InnerHtml = str.ToUpper();
    }

    protected void on_click(object sender, EventArgs e)
    {

    }
</script>

<!-- Layout -->
<html>
   <head> 
      <title> Change to Upper Case </title> 
   </head>
   
   <body>
      <h3> Conversion to Upper Case </h3>
      
      <form runat="server">
         <input runat="server" id="mytext" type="text" />
         <input runat="server" id="button1" type="submit" value="Enter..." OnServerClick="convertoupper"/>
         
         <hr />
         <h3> Results: </h3>
         <span runat="server" id="changed_text" />
          </span>
          <p>
              <asp:Button ID="Button2" runat="server" OnClick="on_click" Text="myButton" />
          </p>
      </form>
      
   </body>
   
</html>
