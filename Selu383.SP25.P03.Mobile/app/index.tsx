import React, { useState } from 'react';
import { View, Text, TouchableOpacity, StyleSheet, FlatList, Dimensions, Image } from 'react-native';

// Seed food data (with images included)
const foodData = [
  { id: 1, name: "Popcorn", description: "Classic buttery popcorn", price: 5.99, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2016/12/31/22/47/popcorn-1085072_960_720.jpg", quantity: 0 },
  { id: 2, name: "Nachos", description: "Cheesy nachos with jalapeños", price: 6.99, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2016/10/23/10/17/chili-1761046_960_720.jpg", quantity: 0 },
  { id: 3, name: "Hotdog", description: "Grilled hotdog with mustard", price: 4.99, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2015/08/21/11/04/hot-dog-897309_960_720.jpg", quantity: 0 },
  { id: 4, name: "Soft Pretzel", description: "Warm salted soft pretzel", price: 3.99, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2017/09/05/15/01/pretzel-2715272_960_720.jpg", quantity: 0 },
  { id: 5, name: "Cheese Sticks", description: "Crispy fried mozzarella sticks", price: 5.49, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2016/06/02/02/12/cheese-1439861_960_720.jpg", quantity: 0 },
  { id: 6, name: "Chicken Tenders", description: "Golden fried chicken tenders", price: 7.49, category: "Snacks", imageUrl: "https://cdn.pixabay.com/photo/2018/02/01/18/54/chicken-3124179_960_720.jpg", quantity: 0 },
  { id: 7, name: "M&M's", description: "Milk chocolate candy", price: 2.99, category: "Candy", imageUrl: "https://images.unsplash.com/photo-1615332587121-72d7a9c2a308", quantity: 0 },
  { id: 8, name: "Skittles", description: "Fruit-flavored candy", price: 2.99, category: "Candy", imageUrl: "https://images.unsplash.com/photo-1601221328884-e7f2b863e2ce", quantity: 0 },
  { id: 9, name: "Twizzlers", description: "Strawberry flavored licorice", price: 2.99, category: "Candy", imageUrl: "https://images.unsplash.com/photo-1626947343469-7e149924c7d2", quantity: 0 },
  { id: 10, name: "Reese’s Pieces", description: "Peanut butter candy", price: 3.49, category: "Candy", imageUrl: "https://images.unsplash.com/photo-1625937320210-2bb4bc944af8", quantity: 0 },
  { id: 11, name: "Coke", description: "Chilled Coca-Cola", price: 3.49, category: "Drinks", imageUrl: "https://www.depositphotos.com/11482235/stock-photo-soft-drinks.html", quantity: 0 },
  { id: 12, name: "Sprite", description: "Refreshing lemon-lime soda", price: 3.49, category: "Drinks", imageUrl: "https://www.depositphotos.com/11582248/stock-photo-soft-drinks.html", quantity: 0 },
  { id: 13, name: "Water", description: "Bottled spring water", price: 2.49, category: "Drinks", imageUrl: "https://cdn.pixabay.com/photo/2016/06/04/13/56/water-1437412_960_720.jpg", quantity: 0 },
  { id: 14, name: "Iced Tea", description: "Cold sweetened iced tea", price: 3.49, category: "Drinks", imageUrl: "https://cdn.pixabay.com/photo/2016/06/10/19/55/iced-tea-1445934_960_720.jpg", quantity: 0 }
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
  const [currentCategory, setCurrentCategory] = useState<string | null>(""); // Track current category
  const { width } = Dimensions.get('window'); // Get screen width

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

  // Calculate total price of the cart
  const calculateTotalPrice = () => {
    return cart.reduce((total, item) => total + item.price * item.quantity, 0).toFixed(2);
  };

  // Separate items by category
  const filterItemsByCategory = (category: string) => {
    return items.filter(item => item.category === category);
  };

  // Handle Category Click
  const handleCategoryClick = (category: string) => {
    setCurrentCategory(category);
  };

  // Handle Back to Menu
  const handleBackToMenu = () => {
    setCurrentCategory(""); // Return to the main menu
  };

  return (
    <View style={styles.container}>
      {/* Main Menu (Category Selection) */}
      {currentCategory === "" ? (
        <>
          <Text style={styles.sectionHeader}>Food and Drinks</Text>
          <View style={styles.menu}>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Snacks")}>
              <Text style={styles.categoryText}>Snacks</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Candy")}>
              <Text style={styles.categoryText}>Candy</Text>
            </TouchableOpacity>
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick("Drinks")}>
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
              <View style={[styles.card, { width: width * 0.45 }]}>
                <Image source={{ uri: item.imageUrl }} style={styles.cardImage} />
                <View style={styles.cardDetails}>
                  <Text style={styles.cardName}>{item.name}</Text>
                  <Text style={styles.cardDescription}>{item.description}</Text>
                  <Text style={styles.cardPrice}>${item.price.toFixed(2)}</Text>
                  <View style={styles.quantityControls}>
                    <TouchableOpacity onPress={() => decrementQuantity(item.id)} style={styles.quantityBtn}>
                      <Text style={styles.quantityText}>-</Text>
                    </TouchableOpacity>
                    <Text style={styles.quantityText}>{item.quantity}</Text>
                    <TouchableOpacity onPress={() => incrementQuantity(item.id)} style={styles.quantityBtn}>
                      <Text style={styles.quantityText}>+</Text>
                    </TouchableOpacity>
                  </View>
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
        {cart.length === 0 ? (
          <Text style={styles.cartWarning}>Your cart is empty. Please add items to the cart.</Text>
        ) : (
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
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginTop: 30,
  },
  categoryCard: {
    backgroundColor: '#007BFF',
    padding: 20,
    borderRadius: 10,
    width: '30%',
    alignItems: 'center',
  },
  categoryText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
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
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
    paddingBottom: 20,
  },
  card: {
    backgroundColor: '#fff',
    borderRadius: 15,
    padding: 15,
    marginRight: 15,
    marginBottom: 15,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.1,
    shadowRadius: 3.5,
    elevation: 5,
    margin: 5,
    minHeight: 250,
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
    color: '#fff',
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
  cartWarning: {
    color: 'red',
    textAlign: 'center',
    fontSize: 16,
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
