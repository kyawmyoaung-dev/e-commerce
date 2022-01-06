import { Grid, List } from "@mui/material";
import { useState, useEffect } from "react";
import { Product } from "../models/Product";
import ProductCard from "./ProductCard";


export default function ProductList() {

    const [products, setProducts] = useState<Product[]>([]);

    useEffect(() => {
        fetch('http://localhost:5000/api/Product')
            .then(response => response.json())
            .then(data => setProducts(data));
    }, []);


    return (
        <Grid container spacing={4}>
            {
                products.map((product) => (
                    <Grid key={product.id} item xs={3}>
                        <ProductCard product={product} />
                    </Grid>
                ))
            }
        </Grid>
    )
}