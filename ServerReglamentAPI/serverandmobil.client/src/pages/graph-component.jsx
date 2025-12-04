import { InMemoryCache } from "@apollo/client";
import { ApolloClient, HttpLink } from '@apollo/client/core'
import { gql } from "@apollo/client";

// работает консоль!
//https://localhost:7079/graphql/

//Запрос проходит!
/*
{
  book {
        title
    author {
            name
        }
    }
}
*/

const client = new ApolloClient({
    link: new HttpLink({ uri: "https://localhost:7079/graphql" }),
    //link: new HttpLink({ uri: "/graphql" }),
    cache: new InMemoryCache(),
});

client
    .query({
        query: gql`
            {
              book {
                    title
                author {
                        name
                    }
                }
            }
    `,
    })
    .then((result) => console.log('SSSSSss = ',result));

function GraphComponent() {


    return (
        <div>
        <h3>Graph MODULE</h3>
        </div>
    );
    

}

export default GraphComponent;