import React from "react";
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
import { NavigationContainer } from "@react-navigation/native";
import Explore from "./(tabs)/explore";
import Index from "./(tabs)/index";

const Tab = createBottomTabNavigator();

export default function Navigation() {
  return (
    <NavigationContainer>
      <Tab.Navigator>
        <Tab.Screen name="Home" component={Index} />
        <Tab.Screen name="Explore" component={Explore} />
      </Tab.Navigator>
    </NavigationContainer>
  );
}
