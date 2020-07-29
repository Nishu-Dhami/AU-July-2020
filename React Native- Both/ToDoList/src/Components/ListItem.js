import React from 'react';
import {StyleSheet,View, Text,Button} from 'react-native';

const ListItem=({textValue,id,onRemove})=>{
    return(
        <View style={styles.container}>
      <Text style={styles.text}>{textValue}</Text>
      <Button color="red" title={"Delete"} onPress={()=>onRemove(id)}/>
    </View>       
    );
}

const styles = StyleSheet.create({
    container: {
      borderBottomColor: '#bbb',
      borderBottomWidth: StyleSheet.hairlineWidth,
      flexDirection: 'row',
      alignItems: 'center',
      justifyContent: 'space-between',
    },
    text: {
      fontSize: 18,
      marginVertical: 20,
      width: 200,
      marginLeft:12,
    },
  });
  

export default ListItem;