import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
//import ReactDOM from 'react-dom';
//import React from 'react';
//import LoginPage from './LoginPage.tsx'
//import RegisterPage from './RegisterPage'


createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <App />
  </StrictMode>,
)
