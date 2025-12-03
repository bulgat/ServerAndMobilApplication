import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import { ApolloClient, InMemoryCache } from "@apollo/client";
//import { HttpLink } from 'apollo-link-http';

const GITHUB_BASE_URL = 'https://api.github.com/graphql';
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
