import React from 'react';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom'; 
import logo from './logounri.png';
import './App.css';
import User from './components/user';
import Blog from './components/blog';
import Account from './components/account';

function App() {
    return (
      <Router>
          <div>
            <Link to="/">Home</Link> |
            <Link to="/account">Account</Link> |
            <Link to="/blog">Blog</Link>
          </div>
          <hr/>
          <img src={logo} className="App-logo" alt="logo" />
            <Route exact path="/" component={User} />
            <Route path="/account" component={Account} />
            <Route path="/blog" component={Blog} />
      </Router>
      
    );
  }


export default App;
