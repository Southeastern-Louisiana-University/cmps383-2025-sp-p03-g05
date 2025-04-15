import React, { useState } from 'react';
import { View, Text, TouchableOpacity, StyleSheet, FlatList, Dimensions } from 'react-native';


const foodData = [
  {
    id: 1,
    name: "Popcorn",
    description: "Classic buttery popcorn",
    price: 5.99,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 2,
    name: "Nachos",
    description: "Cheesy nachos with jalapeños",
    price: 6.99,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 3,
    name: "Hotdog",
    description: "Grilled hotdog with mustard",
    price: 4.99,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 4,
    name: "Soft Pretzel",
    description: "Warm salted soft pretzel",
    price: 3.99,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 5,
    name: "Cheese Sticks",
    description: "Crispy fried mozzarella sticks",
    price: 5.49,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 6,
    name: "Chicken Tenders",
    description: "Golden fried chicken tenders",
    price: 7.49,
    category: "Snacks",
    quantity: 0,
  },
  {
    id: 7,
    name: "M&M's",
    description: "Milk chocolate candy",
    price: 2.99,
    category: "Candy",
    quantity: 0,
  },
  {
    id: 8,
    name: "Skittles",
    description: "Fruit-flavored candy",
    price: 2.99,
    category: "Candy",
    quantity: 0,
  },
  {
    id: 9,
    name: "Twizzlers",
    description: "Strawberry flavored licorice",
    price: 2.99,
    category: "Candy",
    quantity: 0,
  },
  {
    id: 10,
    name: "Reese’s Pieces",
    description: "Peanut butter candy",
    price: 3.49,
    category: "Candy",
    quantity: 0,
  },
  {
    id: 11,
    name: "Coke",
    description: "Chilled Coca-Cola",
    price: 3.49,
    category: "Drinks",
    quantity: 0,
  },
  {
    id: 12,
    name: "Sprite",
    description: "Refreshing lemon-lime soda",
    price: 3.49,
    category: "Drinks",
    quantity: 0,
  },
  {
    id: 13,
    name: "Water",
    description: "Bottled spring water",
    price: 2.49,
    category: "Drinks",
    quantity: 0,
  },
  {
    id: 14,
    name: "Iced Tea",
    description: "Cold sweetened iced tea",
    price: 3.49,
    category: "Drinks",
    quantity: 0,
  }
];

interface FoodDrinkItem {
  id: number;
  name: string;
  description: string;
  price: number;
  category: string;
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
  const [isPaymentModalVisible, setPaymentModalVisible] = useState(false);

  const { width } = Dimensions.get('window');  // Get screen width

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

  const removeFromCart = (itemId: number) => {
    setCart(cart.filter((cartItem) => cartItem.id !== itemId));
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
  const foodItems = items.filter(item => item.category === "Snacks" || item.category === "Candy");
  const drinkItems = items.filter(item => item.category === "Drinks");

  // Show or hide payment modal
  const handlePayment = () => {
    setPaymentModalVisible(true);
  };

  return (
    <View style={styles.container}>
      {/* Snacks & Candy Section */}
      <Text style={styles.sectionHeader}>Snacks & Candy</Text>
      <FlatList
        data={foodItems}
        keyExtractor={(item) => item.id.toString()}
        numColumns={2}
        renderItem={({ item }) => (
          <View style={[styles.card, { width: width * 0.45 }]}>
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

      {/* Drinks Section */}
      <Text style={styles.sectionHeader}>Drinks</Text>
      <FlatList
        data={drinkItems}
        keyExtractor={(item) => item.id.toString()}
        numColumns={2}
        renderItem={({ item }) => (
          <View style={[styles.card, { width: width * 0.45 }]}>
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

        {/* Pay Here Button */}
        {cart.length > 0 && (
          <TouchableOpacity style={styles.payBtn} onPress={handlePayment}>
            <Text style={styles.payText}>Pay Here</Text>
          </TouchableOpacity>
        )}
      </View>

      {/* Payment Modal (just a simple popup for now) */}
      {isPaymentModalVisible && (
        <View style={styles.paymentModal}>
          <Text style={styles.modalText}>Payment Process Initiated</Text>
          <TouchableOpacity onPress={() => setPaymentModalVisible(false)} style={styles.closeBtn}>
            <Text style={styles.closeText}>Close</Text>
          </TouchableOpacity>
        </View>
      )}
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
  itemsList: {
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
    paddingBottom: 20,
  },
  card: {
    backgroundColor: '#fff',
    borderRadius: 10,
    padding: 15,
    marginBottom: 20,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 0.2,
    shadowRadius: 3.5,
    elevation: 5,
    margin: 5,
  },
  cardDetails: {
    alignItems: 'flex-start',
  },
  cardName: {
    fontSize: 18,
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
    padding: 5,
    borderRadius: 5,
    marginHorizontal: 5,
  },
  quantityText: {
    fontSize: 20,
    color: '#fff',
  },
  addToCartBtn: {
    backgroundColor: '#007BFF',
    padding: 10,
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
  paymentModal: {
    position: 'absolute',
    top: '40%',
    left: '10%',
    right: '10%',
    backgroundColor: 'white',
    padding: 20,
    borderRadius: 10,
    alignItems: 'center',
    justifyContent: 'center',
    zIndex: 999,
  },
  modalText: {
    fontSize: 18,
    marginBottom: 20,
  },
  closeBtn: {
    backgroundColor: 'red',
    padding: 10,
    borderRadius: 5,
    marginTop: 10,
  },
  closeText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
});

export default FoodAndDrinkScreen;
