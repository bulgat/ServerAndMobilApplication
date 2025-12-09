import { InMemoryCache } from "@apollo/client";
import { ApolloClient, HttpLink } from '@apollo/client/core'
import { gql } from "@apollo/client";
import { useEffect } from "react";

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
    .then((result) => {
        console.log('0000 SSSS ss = ', result);
        console.log('0001 SSSS ss = ', result.data);
        console.log('0002 SSSS ss = ', result.data.book);
        console.log('0003 SSSS ss = ', result.data.book.author);
        console.log('0004 SSSS ss = ', result.data.book.author.name);
        console.log('0005 SS ss = ', result.data.book.title);
        result = "xxx = " + result.data.book.author.name;
        return (
            <div>
                <h3>Graph MODULE 00</h3>
                <div>
                    {result}
                </div>
            </div>
        );
    });

function GraphComponent() {
    /*
    useEffect(() => {
        //вход
        let cancel = false;
        getPosts().then((data) => {
            if (!cancel) {
                console.log('0 ====== ', data);
                AssertArrayDirective(data);
                setUnitList(data);

            }
        });

        return () => {
            //выход
            console.log('001 r  = ');
            cancel = true;
        }
    }, []);
    */
    return (
        <div>
            <h3>Graph MODULE</h3>
            <div>
                {result}
            </div>
        </div>
    );
    

}

export default GraphComponent;