import React, { useEffect, useState } from 'react';
import {
  View,
  Text,
  FlatList,
  TouchableOpacity,
  StyleSheet,
  Alert,
  ScrollView,
} from 'react-native';

type FoodItem = {
  id: number;
  name: string;
  price: number;
  category: 'food' | 'drink';
  quantity: number;
};

const FoodAndDrinksScreen: React.FC = () => {
  const [items, setItems] = useState<FoodItem[]>([]);

  useEffect(() => {
    fetchFoodItems();
  }, []);

  const fetchFoodItems = () => {
    const mockData: FoodItem[] = [
      { id: 1, name: 'Popcorn', price: 4.99, category: 'food', quantity: 0 },
      { id: 2, name: 'Nachos', price: 5.75, category: 'food', quantity: 0 },
      { id: 3, name: 'Hot Dog', price: 3.99, category: 'food', quantity: 0 },
      { id: 4, name: 'Ice Cream', price: 2.99, category: 'food', quantity: 0 },
      { id: 5, name: 'Coke', price: 2.5, category: 'drink', quantity: 0 },
      { id: 6, name: 'Water Bottle', price: 1.25, category: 'drink', quantity: 0 },
      { id: 7, name: 'Sprite', price: 2.5, category: 'drink', quantity: 0 },
    ];

    setItems(mockData);
  };

  const incrementQuantity = (id: number) => {
    setItems((prevItems) =>
      prevItems.map((item) =>
        item.id === id ? { ...item, quantity: item.quantity + 1 } : item
      )
    );
  };

  const decrementQuantity = (id: number) => {
    setItems((prevItems) =>
      prevItems.map((item) =>
        item.id === id && item.quantity > 0
          ? { ...item, quantity: item.quantity - 1 }
          : item
      )
    );
  };

  const handleReadyForPayment = () => {
    const totalItems = items.reduce((sum, item) => sum + item.quantity, 0);
    if (totalItems === 0) {
      Alert.alert('Cart is empty', 'Please select at least one item.');
    } else {
      Alert.alert('Ready for Payment', 'Proceeding to payment...');
    }
  };

  const renderCategory = (category: 'food' | 'drink') => {
    const categoryItems = items.filter((item) => item.category === category);

    return (
      <View>
        <Text style={styles.categoryHeader}>
          {category === 'food' ? '🍔 Food' : '🥤 Drinks'}
        </Text>
        {categoryItems.map((item) => (
          <View key={item.id} style={styles.itemRow}>
            <View style={styles.itemDetails}>
              <Text style={styles.itemName}>{item.name}</Text>
              <Text style={styles.itemPrice}>${item.price.toFixed(2)}</Text>
            </View>
            <View style={styles.quantityControls}>
              <TouchableOpacity
                style={styles.qBtn}
                onPress={() => decrementQuantity(item.id)}
              >
                <Text style={styles.qBtnText}>-</Text>
              </TouchableOpacity>
              <Text style={styles.quantityText}>{item.quantity}</Text>
              <TouchableOpacity
                style={styles.qBtn}
                onPress={() => incrementQuantity(item.id)}
              >
                <Text style={styles.qBtnText}>+</Text>
              </TouchableOpacity>
            </View>
          </View>
        ))}
      </View>
    );
  };

  const totalItems = items.reduce((sum, item) => sum + item.quantity, 0);
  const totalPrice = items.reduce(
    (sum, item) => sum + item.quantity * item.price,
    0
  );

  return (
    <View style={styles.container}>
      <Text style={styles.header}>Food & Drinks Menu</Text>
      <ScrollView>
        {renderCategory('food')}
        {renderCategory('drink')}
      </ScrollView>
      <View style={styles.footer}>
        <Text style={styles.totalText}>Total Items: {totalItems}</Text>
        <Text style={styles.totalText}>Total: ${totalPrice.toFixed(2)}</Text>

        <TouchableOpacity
          style={styles.paymentButton}
          onPress={handleReadyForPayment}
        >
          <Text style={styles.paymentButtonText}>Ready for Payment</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

export default FoodAndDrinksScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: '#fff',
  },
  header: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 16,
    textAlign: 'center',
  },
  categoryHeader: {
    fontSize: 20,
    fontWeight: '600',
    marginTop: 20,
    marginBottom: 10,
    borderBottomWidth: 1,
    borderBottomColor: '#ddd',
  },
  itemRow: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    paddingVertical: 10,
    borderBottomColor: '#eee',
    borderBottomWidth: 1,
  },
  itemDetails: {
    flex: 1,
  },
  itemName: {
    fontSize: 16,
    fontWeight: '500',
  },
  itemPrice: {
    color: '#555',
    marginTop: 2,
  },
  quantityControls: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  qBtn: {
    backgroundColor: '#007bff',
    padding: 6,
    borderRadius: 5,
    width: 30,
    alignItems: 'center',
  },
  qBtnText: {
    color: '#fff',
    fontSize: 18,
    fontWeight: 'bold',
  },
  quantityText: {
    marginHorizontal: 12,
    fontSize: 16,
    fontWeight: '500',
  },
  footer: {
    paddingTop: 20,
    borderTopWidth: 1,
    borderTopColor: '#ddd',
    marginTop: 20,
    alignItems: 'center',
  },
  totalText: {
    fontSize: 16,
    fontWeight: '600',
    marginVertical: 4,
  },
  paymentButton: {
    marginTop: 15,
    backgroundColor: '#28a745',
    paddingVertical: 12,
    paddingHorizontal: 24,
    borderRadius: 8,
  },
  paymentButtonText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
});
