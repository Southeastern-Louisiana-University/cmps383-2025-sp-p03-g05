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
  const [currentCategory, setCurrentCategory] = useState<string>("");

  const { width, height } = Dimensions.get('window');

  const removeFromCart = (id: number) => {
    setCart(prevCart => prevCart.filter(item => item.id !== id));
  };

  const addToCart = (item: FoodDrinkItem) => {
    const existingItem = cart.find(cartItem => cartItem.id === item.id);
    if (existingItem) {
      setCart(cart.map(cartItem =>
        cartItem.id === item.id
          ? { ...cartItem, quantity: cartItem.quantity + 1 }
          : cartItem
      ));
    } else {
      setCart([...cart, { ...item, quantity: 1 }]);
    }
  };

  const incrementQuantity = (itemId: number) => {
    setCart(cart.map(cartItem =>
      cartItem.id === itemId
        ? { ...cartItem, quantity: cartItem.quantity + 1 }
        : cartItem
    ));
  };

  const decrementQuantity = (itemId: number) => {
    setCart(cart.map(cartItem =>
      cartItem.id === itemId && cartItem.quantity > 1
        ? { ...cartItem, quantity: cartItem.quantity - 1 }
        : cartItem
    ));
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
      {currentCategory === "" ? (
        <FlatList
          data={[
            { name: "Snacks", imageUrl: "https://media.istockphoto.com/id/1488301035/photo/buying-movie-tickets.jpg?s=612x612&w=0&k=20&c=kdnjbb3rUARYuq7zuweV89xyHJf2LNen8d6DAHLaiH4=" },
            { name: "Candy", imageUrl: "https://townsquare.media/site/442/files/2018/11/movie-theater-candies.jpg?w=780&q=75" },
            { name: "Drinks", imageUrl: "https://c8.alamy.com/comp/WX0H5W/bottles-of-global-soft-drink-brands-including-products-of-coca-cola-company-and-pepsico-WX0H5W.jpg" },
          ]}
          renderItem={({ item }) => (
            <TouchableOpacity style={styles.categoryCard} onPress={() => handleCategoryClick(item.name)}>
              <Image source={{ uri: item.imageUrl }} style={styles.categoryImage} />
              <View style={styles.overlay}>
                <Text style={styles.categoryText}>{item.name}</Text>
              </View>
            </TouchableOpacity>
          )}
          keyExtractor={(item) => item.name}
          showsVerticalScrollIndicator={false}
          contentContainerStyle={{ paddingBottom: 20 }}
        />
      ) : (
        <>
          <TouchableOpacity style={styles.backBtn} onPress={handleBackToMenu}>
            <Text style={styles.backText}>← Back</Text>
          </TouchableOpacity>

          <FlatList
            data={filterItemsByCategory(currentCategory)}
            keyExtractor={(item) => item.id.toString()}
            renderItem={({ item }) => (
              <View style={styles.foodCard}>
                <Image source={{ uri: item.imageUrl }} style={styles.foodImage} />
                <View style={styles.foodDetails}>
                  <Text style={styles.foodName}>{item.name}</Text>
                  <Text style={styles.foodDescription}>{item.description}</Text>
                  <Text style={styles.foodPrice}>${item.price.toFixed(2)}</Text>
                  <TouchableOpacity style={styles.addToCartBtn} onPress={() => addToCart(item)}>
                    <Text style={styles.addToCartText}>Add to Cart</Text>
                  </TouchableOpacity>
                </View>
              </View>
            )}
            showsVerticalScrollIndicator={false}
            contentContainerStyle={{ paddingBottom: 20 }}
          />
        </>
      )}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#121212',
    paddingTop: 20,
    paddingHorizontal: 10,
  },
  categoryCard: {
    width: '100%',
    height: 250,
    borderRadius: 20,
    marginBottom: 20,
    overflow: 'hidden',
  },
  categoryImage: {
    width: '100%',
    height: '100%',
  },
  overlay: {
    ...StyleSheet.absoluteFillObject,
    backgroundColor: 'rgba(0,0,0,0.35)',
    justifyContent: 'center',
    alignItems: 'center',
  },
  categoryText: {
    color: '#fff',
    fontSize: 26,
    fontWeight: 'bold',
    textShadowColor: '#000',
    textShadowOffset: { width: 2, height: 2 },
    textShadowRadius: 5,
  },
  backBtn: {
    backgroundColor: '#333',
    padding: 12,
    borderRadius: 10,
    marginBottom: 10,
    alignSelf: 'flex-start',
  },
  backText: {
    color: '#fff',
    fontSize: 16,
  },
  foodCard: {
    backgroundColor: '#1f1f1f',
    borderRadius: 15,
    overflow: 'hidden',
    marginBottom: 20,
  },
  foodImage: {
    width: '100%',
    height: 180,
  },
  foodDetails: {
    padding: 10,
  },
  foodName: {
    color: '#fff',
    fontSize: 18,
    fontWeight: 'bold',
    marginBottom: 5,
  },
  foodDescription: {
    color: '#aaa',
    fontSize: 14,
    marginBottom: 5,
  },
  foodPrice: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
    marginBottom: 10,
  },
  addToCartBtn: {
    backgroundColor: '#a800b7',
    padding: 10,
    borderRadius: 10,
    alignItems: 'center',
  },
  addToCartText: {
    color: '#fff',
    fontSize: 16,
    fontWeight: 'bold',
  },
});

export default FoodAndDrinkScreen;