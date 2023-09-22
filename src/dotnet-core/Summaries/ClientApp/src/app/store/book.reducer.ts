import * as bookActions from './book.actions';
import * as types from './action.types';
import { AppState } from './app.state';

export const initialState: AppState =
{
    books: []
}

export function BookReducer(state = initialState, action: bookActions.Actions)
{
    switch(action.type)
    {
        case types.LOAD_BOOKS_SUCCESS: 
        {
            return {...state, books: action.payload}
        }
        default:
            return state;
    }
}