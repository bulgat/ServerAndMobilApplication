import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import { InMemoryCache } from "@apollo/client";
//import { HttpLink } from 'apollo-link-http';
import { ApolloClient, HttpLink } from '@apollo/client/core'
import { gql } from "@apollo/client";

const GITHUB_BASE_URL = 'https://api.github.com/graphql';

const client = new ApolloClient({
    link: new HttpLink({ uri: "https://flyby-router-demo.herokuapp.com/" }),
    cache: new InMemoryCache(),
});

client
    .query({
        query: gql`
      query GetLocations {
        locations {
          id
          name
          description
          photo
        }
      }
    `,
    })
    .then((result) => console.log('result = ',result));

/*
const httpLink = new HttpLink({
    uri: GITHUB_BASE_URL,
    headers: {
        //authorization: `Bearer ${process.env.REACT_APP_GITHUB_PERSONAL_ACCESS_TOKEN
            //}`,
    },
});

const client = new ApolloClient({
    //link: httpLink,
    uri: "YOUR_GRAPHQL_API_ENDPOINT",
    cache: new InMemoryCache(),
});
*/
createRoot(document.getElementById('root')).render(
    <StrictMode>
 
        <App />
 
  </StrictMode>,
)
