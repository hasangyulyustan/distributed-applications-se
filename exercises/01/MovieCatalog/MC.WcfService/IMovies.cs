using MC.Data.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace MC.WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovies" in both code and config file together.
    [ServiceContract]
    public interface IMovies
    {

        [OperationContract]
        List<Movie> GetMovies();

        [OperationContract]
        string PostMovie(Movie movie);

        [OperationContract]
        string PutMovie(Movie movie);

        [OperationContract]
        string DeleteMovie(int id);

    }
}
