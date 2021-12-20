namespace Cesium.Ast;

public abstract record Expression;

// 6.5.1 Primary expressions
public record IdentifierExpression(string Identifier) : Expression;
public record ConstantExpression(string Constant) : Expression;

// 6.5.5–6.5.15: Various binary operators
public record BinaryOperatorExpression(Expression Left, string Operator, Expression Right) : Expression;
