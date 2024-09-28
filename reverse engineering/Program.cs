namespace reverse_engineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver -Tables tableName , ..
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver -OutputDir FolderName => add classes in folder
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver -ContextDir FolderName => add Context in folder
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver -Context ContextName => change Context Name
            //scaffold-dbcontext "connection string" microsoft.entityframeworkcore.sqlserver -DataAnnotations => change Context Name

            Console.WriteLine("Hello, World!");
        }
    }
}
