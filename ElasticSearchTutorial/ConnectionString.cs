using Elasticsearch.Net;

internal class ConnectionString
{
    private SingleNodeConnectionPool pool;

    public ConnectionString(SingleNodeConnectionPool pool)
    {
        this.pool = pool;
    }

    internal object DefaultIndex(string v)
    {
        throw new NotImplementedException();
    }
}