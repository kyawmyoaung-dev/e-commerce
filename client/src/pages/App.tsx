import React, { useEffect, useState } from 'react';
import { Product } from '../models/Product';
import './style.css';
import ProductList from '../components/ProductList';
import Header from '../layout/Header';
import { Container, CssBaseline } from '@mui/material';
function App() {

  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch('http://localhost:5000/api/Product')
      .then(response => response.json())
      .then(data => setProducts(data));
  }, []);



  return (
    <div>
      <CssBaseline />
      <Header />
      <Container>
        <ProductList products={products} />
      </Container>

    </div>
  );
}

export default App;
