import { InMemoryCache } from "@apollo/client";
import { ApolloClient, HttpLink } from '@apollo/client/core'
import { gql } from "@apollo/client";
import { useEffect } from "react";
import { PrintDirective } from "../component/print-directive";

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
let result = "";

const client = new ApolloClient({
    link: new HttpLink({ uri: "https://localhost:7079/graphql" }),
    //link: new HttpLink({ uri: "/graphql" }),
    cache: new InMemoryCache(),
});

function GraphComponent() {

    useEffect(() => {
        //вход
        let cancel = false;
        client.query({
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
            .then((res) => {
                console.log('1000 SSS ss = ', res);
                console.log('1002 SSSS ss = ', res.data.book);
                console.log('1003 SSSS ss = ', res.data.book.author);
                console.log('1004 SSSS ss = ', res.data.book.author.name);
                console.log('1005 SS ss = ', res.data.book.title);

                result = "title = " + res.data.book.title + " author = " + res.data.book.author.name;
                /*
                return (
                    <div>
                        <h3>Graph MODULE 0012</h3>
                        <div>
                            {res}
                        </div>
                        <PrintDirective name={res.data.book.author.name} />
                    </div>
                );
                */
            });

        return () => {
            //выход
            console.log('0999 выход  = ');
            cancel = true;
        }
    }, []);

    return (
        <div>
            <h3>Graph MODULE</h3>
            <div>
            </div>
            <PrintDirective name={result} />
        </div>
    );
}

export default GraphComponent;
