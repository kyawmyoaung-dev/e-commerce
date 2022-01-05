import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, ListItem, ListItemAvatar, ListItemText, Typography } from "@mui/material";
import { Product } from "../models/Product";

interface Props {
    product: Product
}

export default function ProductCard({ product }: Props) {

    return (
        <Card>
            <CardHeader
                avatar={
                    <Avatar>{product.name.charAt(0).toUpperCase()}</Avatar>
                }
                title={product.name}
                titleTypographyProps={{
                    sx: { fontWeight: 'bold', color: 'primary.main' }
                }} />
           <CardMedia
                sx={{ height: 140, backgroundSize: 'contain', bgcolor: 'primary.light' }}
                image={'http://localhost:5000'+product.pictureUrl}
                title={product.name}
            />
            <CardContent>
                <Typography gutterBottom color='secondary' variant="h5">
                    ${(product.price / 100).toFixed(2)}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    {product.brand} / {product.type}
                </Typography>
            </CardContent>
            <CardActions>
                <Button size="small">Add to card</Button>
                <Button size="small">View</Button>
            </CardActions>
        </Card>
    )
}