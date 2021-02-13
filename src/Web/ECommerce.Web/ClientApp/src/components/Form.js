import react, { useState } from 'react';
import { Grid, Button, TextField } from '@material-ui/core';
import { v4 as uuidv4 } from 'uuid';

const Form = () => {
  const initialInputState = {
    ISBN: '',
  };
  const [formDataEntry, updateFormData] = useState(initialInputState);
  const { ISBN } = formDataEntry;

  const handleInputChange = (e) => {
    updateFormData({ ...formDataEntry, [e.target.name]: e.target.value });
  };

  const submitHandler = (e) => {
    fetch('https://localhost:44300/api/book/create', {
      method: 'post',
      headers: {
        'Content-Type': 'application/json',
        //'Cache-Control': 'max-age=3600',
      },
      body: JSON.stringify(formDataEntry),
    }).then(
      (response) => {
        console.log(response);
      },
      (err) => {
        console.error(err.message);
      }
    );
  };

  const textFieldPropsAndValues = [
    {
      id: 1,
      label: 'ISBN',
      name: 'ISBN',
      value: ISBN,
      onChange: handleInputChange,
      placeholder: 'Enter ISBN here...',
      // className: props.style.styleTextField,
    },
  ];

  return (
    <form>
      <Grid container onSubmit={submitHandler} direction='column'>
        <Grid item>
          {textFieldPropsAndValues.map((textFieldProps) => {
            const { id, ...propsAndValues } = textFieldProps;
            return <TextField key={id} {...propsAndValues} />;
          })}
          <Grid />
          <Grid item>
            <Button
              variant='contained'
              color='primary'
              // type='submit'
              onClick={submitHandler}
            >
              Send
            </Button>
          </Grid>
        </Grid>
      </Grid>
    </form>
  );
};

export default Form;
