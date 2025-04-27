import React, { useState } from "react";
import { View, TextInput, Button, Alert, StyleSheet } from "react-native";
import axios from "axios";
import { useRouter } from "expo-router";

export default function ChangePassword() {
  const [currentPassword, setCurrentPassword] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const router = useRouter();

  const handleSubmit = async () => {
    if (!currentPassword || !newPassword) {
      Alert.alert("Missing Fields", "Please fill out both fields.");
      return;
    }

    try {
      await axios.post(
        "https://selu383-sp25-p03-g05.azurewebsites.net/api/users/change-password", 
        {
          currentPassword,
          newPassword,
        },
        {
          withCredentials: true, 
        }
      );

      Alert.alert("Success", "Password changed successfully!");
      router.back(); 
    } catch (err: any) {
      console.error(err.response?.data || err);
      Alert.alert(
        "Error",
        err.response?.data?.title || "Could not change password"
      );
    }
  };

  return (
    <View style={styles.container}>
      <TextInput
        placeholder="Current Password"
        value={currentPassword}
        onChangeText={setCurrentPassword}
        secureTextEntry
        style={styles.input}
      />
      <TextInput
        placeholder="New Password"
        value={newPassword}
        onChangeText={setNewPassword}
        secureTextEntry
        style={styles.input}
      />
      <Button title="Change Password" onPress={handleSubmit} />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    padding: 20,
    gap: 12,
  },
  input: {
    borderBottomWidth: 1,
    paddingVertical: 8,
    fontSize: 16,
  },
});
