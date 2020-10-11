## Partial Application
- 함수 파라메터의 일부를 반영한 새로운 함수를 만드는 방법이다.

## Curry
- Curry는 Partial Application의 유형중 하나이다.
- Curry는 단일 파라메터만 입력 받는다.
- Curry는 F#에서 기본적으로 지원하는 파라메터 입력 방식이다.
- `f : (int, int, int) -> int`
- `f : int -> int -> int -> int`
