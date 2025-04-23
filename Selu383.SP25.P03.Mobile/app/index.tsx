import React, { useState } from 'react';
import { View, Text, TouchableOpacity, StyleSheet, FlatList, Dimensions, Image } from 'react-native';

const foodData = [
  { id: 1, name: "Popcorn", description: "Classic buttery popcorn", price: 5.99, category: "Snacks", imageUrl: "https://www.100daysofrealfood.com/wp-content/uploads/2011/06/popcorn1.jpg", quantity: 0 },
  { id: 2, name: "Nachos", description: "Cheesy nachos with jalapeños", price: 6.99, category: "Snacks", imageUrl: "https://www.tastyrewards.com/sites/default/files/2024-01/Ultimate%20Four%20Cheese%20Nachos.jpg", quantity: 0 },
  { id: 3, name: "Hotdog", description: "Grilled hotdog with mustard", price: 4.99, category: "Snacks", imageUrl: "https://potatorolls.com/wp-content/uploads/2020/10/Basic-Hot-Dogs-960x640.jpg", quantity: 0 },
  { id: 4, name: "Soft Pretzel", description: "Warm salted soft pretzel", price: 3.99, category: "Snacks", imageUrl: "https://sallysbakingaddiction.com/wp-content/uploads/2017/04/easy-homemade-soft-pretzels.jpg", quantity: 0 },
  { id: 5, name: "Cheese Sticks", description: "Crispy fried mozzarella sticks", price: 5.49, category: "Snacks", imageUrl: "https://easyweeknightrecipes.com/wp-content/uploads/2024/04/Mozzarella-Sticks_0013.jpg", quantity: 0 },
  { id: 6, name: "Chicken Tenders", description: "Golden fried chicken tenders", price: 7.49, category: "Snacks", imageUrl: "https://www.allrecipes.com/thmb/YwJvX75IUx8uQ7PKz2eTDjCoLvY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/16669-fried-chicken-tenders-DDMFS-4x3-219f03b885be40139c8d93bef21d0a50.jpg", quantity: 0 },
  { id: 7, name: "M&M's", description: "Milk chocolate candy", price: 2.99, category: "Candy", imageUrl: "https://i.ebayimg.com/images/g/JPkAAOSwMONgEygQ/s-l400.jpg", quantity: 0 },
  { id: 8, name: "Skittles", description: "Fruit-flavored candy", price: 2.99, category: "Candy", imageUrl: "https://compote.slate.com/images/79fb3cf9-c3a6-403c-b29a-d9bb6f086a36.jpeg?crop=1560%2C1040%2Cx0%2Cy0", quantity: 0 },
  { id: 9, name: "Twizzlers", description: "Strawberry flavored licorice", price: 2.99, category: "Candy", imageUrl: "https://rebellwrap.vtexassets.com/arquivos/ids/1129213-800-auto?v=638185540871400000&width=800&height=auto&aspect=true", quantity: 0 },
  { id: 10, name: "Reese’s Pieces", description: "Peanut butter candy", price: 3.49, category: "Candy", imageUrl: "https://itsugar.com/cdn/shop/files/Screenshot2024-04-25at4.45.20PM.png?v=1714755068&width=709", quantity: 0 },
  { id: 11, name: "Coke", description: "Chilled Coca-Cola", price: 3.49, category: "Drinks", imageUrl: "https://www.basicfun.com/wp-content/uploads/2023/07/34081_CocaCola_Item_F_Coke.jpg", quantity: 0 },
  { id: 12, name: "Sprite", description: "Refreshing lemon-lime soda", price: 3.49, category: "Drinks", imageUrl: "https://i5.walmartimages.com/asr/23b7de79-cfc6-4764-a720-957aa667ec76.1708f37e94750898290d92adf357f112.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF", quantity: 0 },
  { id: 13, name: "Water", description: "Bottled spring water", price: 2.49, category: "Drinks", imageUrl: "https://kidspressmagazine.com/wp-content/uploads/2014/04/dreamstime_xl_12522351.jpg", quantity: 0 },
  { id: 14, name: "Iced Tea", description: "Cold sweetened iced tea", price: 3.49, category: "Drinks", imageUrl: "https://bakingmehungry.com/wp-content/uploads/2024/05/lipton-iced-tea-recipe-8.jpg", quantity: 0 }
];

interface FoodDrinkItem {
  id: number;
  name: string;
  description: string;
  price: number;
  category: string;
  imageUrl: string;
  quantity: number;
}

interface CartItem {
  id: number;
  name: string;
  price: number;
  quantity: number;
}

const FoodAndDrinkScreen: React.FC = () => {
  const [items, setItems] = useState<FoodDrinkItem[]>(foodData);
  const [cart, setCart] = useState<CartItem[]>([]);
  const removeFromCart = (id: number) => {
    setCart((prevCart) => prevCart.filter(item => item.id !== id));
  };

  const [currentCategory, setCurrentCategory] = useState<string>("");
  const { width } = Dimensions.get('window'); 

  const addToCart = (item: FoodDrinkItem) => {
    const existingItem = cart.find((cartItem) => cartItem.id === item.id);
    if (existingItem) {
      setCart(
        cart.map((cartItem) =>
          cartItem.id === item.id
            ? { ...cartItem, quantity: cartItem.quantity + 1 }
            : cartItem
        )
      );
    } else {
      setCart([...cart, { ...item, quantity: 1 }]);
    }
  };

  const incrementQuantity = (itemId: number) => {
    setCart(
      cart.map((cartItem) =>
        cartItem.id === itemId ? { ...cartItem, quantity: cartItem.quantity + 1 } : cartItem
      )
    );
  };

  const decrementQuantity = (itemId: number) => {
    setCart(
      cart.map((cartItem) =>
        cartItem.id === itemId && cartItem.quantity > 1
          ? { ...cartItem, quantity: cartItem.quantity - 1 }
          : cartItem
      )
    );
  };

  const calculateTotalPrice = () => {
    return cart.reduce((total, item) => total + item.price * item.quantity, 0).toFixed(2);
  };

  const filterItemsByCategory = (category: string) => {
    return items.filter(item => item.category === category);
  };

  const handleCategoryClick = (category: string) => {
    setCurrentCategory(category);
  };

  const handleBackToMenu = () => {
    setCurrentCategory(""); 
  };

  return (
    <View style={styles.container}>
      {/* Main Menu (Category Selection) */}
      {currentCategory === "" ? (
        <>
          <Text style={styles.sectionHeader}>Food and Drinks</Text>
          <View style={styles.menu}>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Snacks")}>
              <Image source={{ uri: "https://media.istockphoto.com/id/1488301035/photo/buying-movie-tickets.jpg?s=612x612&w=0&k=20&c=kdnjbb3rUARYuq7zuweV89xyHJf2LNen8d6DAHLaiH4=" }} style={styles.categoryImage} />
              <Text style={styles.categoryText}>Snacks</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Candy")}>
              <Image source={{ uri: "https://townsquare.media/site/442/files/2018/11/movie-theater-candies.jpg?w=780&q=75" }} style={styles.categoryImage} />
              <Text style={styles.categoryText}>Candy</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Drinks")}>
              <Image source={{ uri: "https://c8.alamy.com/comp/WX0H5W/bottles-of-global-soft-drink-brands-including-products-of-coca-cola-company-and-pepsico-WX0H5W.jpg" }} style={styles.categoryImage} />
              <Text style={styles.categoryText}>Drinks</Text>
            </TouchableOpacity>
          </View>
        </>
      ) : (
        <>
          {/* Category Section (Snacks, Candy, Drinks) */}
          <TouchableOpacity style={styles.backBtn} onPress={handleBackToMenu}>
            <Text style={styles.backText}>Back to Menu</Text>
          </TouchableOpacity>

          <Text style={styles.sectionHeader}>{currentCategory}</Text>
          <FlatList
            data={filterItemsByCategory(currentCategory)}
            keyExtractor={(item) => item.id.toString()}
            renderItem={({ item }) => (
              <View style={[styles.card, { width: width * 0.9, marginBottom: 15 }]}>
                <Image source={{ uri: item.imageUrl }} style={styles.cardImage} />
                <View style={styles.cardDetails}>
                  <Text style={styles.cardName}>{item.name}</Text>
                  <Text style={styles.cardDescription}>{item.description}</Text>
                  <Text style={styles.cardPrice}>${item.price.toFixed(2)}</Text>
                  <TouchableOpacity style={styles.addToCartBtn} onPress={() => addToCart(item)}>
                    <Text style={styles.addToCartText}>Add to Cart</Text>
                  </TouchableOpacity>
                </View>
              </View>
            )}
            contentContainerStyle={styles.itemsList}
          />
        </>
      )}

      {/* Cart Section */}
      <View style={styles.cart}>
        {cart.length === 0 ? null : (  
          <View style={styles.cartItems}>
            {cart.map((item) => (
              <View key={item.id} style={styles.cartItem}>
                <Text>{item.name} - ${item.price.toFixed(2)} x {item.quantity}</Text>
                <View style={styles.quantityControls}>
                  <TouchableOpacity onPress={() => decrementQuantity(item.id)} style={styles.quantityBtn}>
                    <Text style={styles.quantityText}>-</Text>
                  </TouchableOpacity>
                  <Text style={styles.quantityText}>{item.quantity}</Text>
                  <TouchableOpacity onPress={() => incrementQuantity(item.id)} style={styles.quantityBtn}>
                    <Text style={styles.quantityText}>+</Text>
                  </TouchableOpacity>
                </View>
                <TouchableOpacity onPress={() => removeFromCart(item.id)} style={styles.removeBtn}>
                  <Text style={styles.removeText}>Remove</Text>
                </TouchableOpacity>
              </View>
            ))}
          </View>
        )}

        <View style={styles.totalPrice}>
          <Text>Total Price: ${calculateTotalPrice()}</Text>
        </View>

        {/* Continue to Purchase Button */}
        {cart.length > 0 && (
          <TouchableOpacity style={styles.payBtn} onPress={() => alert("Proceeding to checkout...")}>
            <Text style={styles.payText}>Continue to Purchase</Text>
          </TouchableOpacity>
        )}
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: '#f5f5f5',
  },
  sectionHeader: {
    fontSize: 24,
    fontWeight: 'bold',
    marginVertical: 10,
    color: '#333',
  },
  menu: {
    flexDirection: 'column', 
    alignItems: 'center',
    marginTop: 30,
  },
  categoryCard: {
    backgroundColor: '#fff',
    padding: 0,
    borderRadius: 15,
    width: '100%',
    height: 200, 
    marginBottom: 20,
    alignItems: 'center',
    justifyContent: 'flex-end', 
    elevation: 5,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.1,
    shadowRadius: 3.5,
  },
  categoryImage: {
    width: '100%',
    height: '100%', 
    borderRadius: 15,
  },
  categoryText: {
    position: 'absolute',
    bottom: 20,
    left: 20,
    color: '#fff',
    fontSize: 18,
    fontWeight: 'bold',
    textShadowColor: 'rgba(0, 0, 0, 0.7)', 
    textShadowOffset: { width: 1, height: 1 },
    textShadowRadius: 3,
  },
  backBtn: {
    backgroundColor: 'gray',
    padding: 10,
    borderRadius: 5,
    marginBottom: 15,
    alignItems: 'center',
  },
  backText: {
    color: '#fff',
    fontSize: 16,
  },
  itemsList: {
    marginBottom: 20,
  },
  card: {
    backgroundColor: '#fff',
    borderRadius: 15,
    padding: 15,
    marginBottom: 15,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.1,
    shadowRadius: 3.5,
    elevation: 5,
    margin: 5,
  },
  cardImage: {
    width: '100%',
    height: 150, 
    borderRadius: 10,
    marginBottom: 10,
  },
  cardDetails: {
    alignItems: 'flex-start',
    justifyContent: 'space-between',
    flex: 1,
  },
  cardName: {
    fontSize: 16,
    fontWeight: 'bold',
    marginBottom: 5,
  },
  cardDescription: {
    fontSize: 14,
    color: '#777',
    marginBottom: 5,
  },
  cardPrice: {
    fontSize: 16,
    color: '#333',
    marginBottom: 10,
  },
  addToCartBtn: {
    backgroundColor: '#007BFF',
    padding: 12,
    borderRadius: 5,
    marginTop: 10,
    width: '100%',
    alignItems: 'center',
  },
  addToCartText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
  cart: {
    marginTop: 30,
  },
  cartItems: {
    marginBottom: 20,
  },
  cartItem: {
    padding: 15,
    backgroundColor: '#f1f1f1',
    borderRadius: 10,
    marginBottom: 15,
  },
  quantityControls: {
    flexDirection: 'row',
    alignItems: 'center',
    marginVertical: 10,
  },
  quantityBtn: {
    backgroundColor: '#007BFF',
    padding: 8,
    borderRadius: 5,
    marginHorizontal: 5,
  },
  quantityText: {
    fontSize: 20,
    color: '#000', 
  },
  removeBtn: {
    backgroundColor: 'red',
    padding: 10,
    borderRadius: 5,
    marginTop: 10,
    width: '100%',
    alignItems: 'center',
  },
  removeText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
  totalPrice: {
    fontSize: 18,
    fontWeight: 'bold',
    marginTop: 20,
    alignItems: 'center',
  },
  payBtn: {
    backgroundColor: '#28a745',
    padding: 15,
    borderRadius: 5,
    marginTop: 20,
    width: '100%',
    alignItems: 'center',
  },
  payText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
});

export default FoodAndDrinkScreen;
