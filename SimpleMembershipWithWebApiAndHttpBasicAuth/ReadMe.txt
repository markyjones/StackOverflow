Response to question here.

Be sure to manaully set your connection string to a physical path:

<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-MvcApplication3-20121215104323;Integrated Security=SSPI;AttachDBFilename=C:\mydatabase\file\path\example\aspnet-MvcApplication-20121215104323.mdf" providerName="System.Data.SqlClient" />
</connectionStrings>