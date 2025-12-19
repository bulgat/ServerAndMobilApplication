import { InMemoryCache } from "@apollo/client";
import { ApolloClient, HttpLink } from '@apollo/client/core'
import { gql } from "@apollo/client";
import { useEffect } from "react";
import { PrintDirective } from "../component/print-directive";

// работает консоль!
//https://localhost:7079/graphql/



let result = "";

const client = new ApolloClient({
    link: new HttpLink({ uri: "https://localhost:7079/graphql" }),
    //link: new HttpLink({ uri: "/graphql" }),
    cache: new InMemoryCache(),
});
//Запрос проходит!
const query_0 = gql`
            {
              book {
                    title
                author {
                        name
                    }
                }
            }
    `;
const query_1 = gql`
            {
              book {
                    title
                }
            }
    `;
const query_2 = gql`
            {
              score {
                    id,
                    name,
                    family
                }
            }
    `;
const query_3 = gql`
            {
              score {
                    id,
                    name,
                    family
                }
            }
    `;
const query_4 = gql`
            {
              player {
                    id,
                    name,
                    family
                }
            }
    `;
const query_5 = gql`
            {
              player(id:3) {
                    id,
                    name,
                    family
                }
            }
    `;

function GraphComponent() {

    useEffect(() => {
        //вход
        let cancel = false;
        client.query({
            query: query_5,
        })
            .then((res) => {

                console.log('1002 SSSS ss = ', res.data.book);

                result = "title = " + res.data.book?.title + " author = " + res.data.book?.author?.name;
            });

        return () => {
            //выход

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
