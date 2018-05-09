//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/91018/PycharmProjects/XASM_Assembler/_gen\Lua.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace _gen {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="LuaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface ILuaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.chunk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChunk([NotNull] LuaParser.ChunkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.chunk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChunk([NotNull] LuaParser.ChunkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] LuaParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] LuaParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>empty_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty_stat([NotNull] LuaParser.Empty_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>empty_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty_stat([NotNull] LuaParser.Empty_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>assign_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign_stat([NotNull] LuaParser.Assign_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assign_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign_stat([NotNull] LuaParser.Assign_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>func_call_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_call_stat([NotNull] LuaParser.Func_call_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>func_call_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_call_stat([NotNull] LuaParser.Func_call_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>break_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreak_stat([NotNull] LuaParser.Break_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>break_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreak_stat([NotNull] LuaParser.Break_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>do_end_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDo_end_stat([NotNull] LuaParser.Do_end_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>do_end_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDo_end_stat([NotNull] LuaParser.Do_end_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>while_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_stat([NotNull] LuaParser.While_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>while_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_stat([NotNull] LuaParser.While_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>if_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_stat([NotNull] LuaParser.If_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>if_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_stat([NotNull] LuaParser.If_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>func_def_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_def_stat([NotNull] LuaParser.Func_def_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>func_def_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_def_stat([NotNull] LuaParser.Func_def_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>global_func_def_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_func_def_stat([NotNull] LuaParser.Global_func_def_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>global_func_def_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_func_def_stat([NotNull] LuaParser.Global_func_def_statContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>global_var_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_var_stat([NotNull] LuaParser.Global_var_statContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>global_var_stat</c>
	/// labeled alternative in <see cref="LuaParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_var_stat([NotNull] LuaParser.Global_var_statContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.retstat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRetstat([NotNull] LuaParser.RetstatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.retstat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRetstat([NotNull] LuaParser.RetstatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncname([NotNull] LuaParser.FuncnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncname([NotNull] LuaParser.FuncnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.varlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarlist([NotNull] LuaParser.VarlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.varlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarlist([NotNull] LuaParser.VarlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamelist([NotNull] LuaParser.NamelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamelist([NotNull] LuaParser.NamelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplist([NotNull] LuaParser.ExplistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplist([NotNull] LuaParser.ExplistContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_and_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_and_exp([NotNull] LuaParser.Op_and_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_and_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_and_exp([NotNull] LuaParser.Op_and_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_or_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_or_exp([NotNull] LuaParser.Op_or_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_or_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_or_exp([NotNull] LuaParser.Op_or_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>num_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNum_exp([NotNull] LuaParser.Num_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>num_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNum_exp([NotNull] LuaParser.Num_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>prefix_exp_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefix_exp_exp([NotNull] LuaParser.Prefix_exp_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>prefix_exp_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefix_exp_exp([NotNull] LuaParser.Prefix_exp_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_mul_div_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_mul_div_exp([NotNull] LuaParser.Op_mul_div_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_mul_div_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_mul_div_exp([NotNull] LuaParser.Op_mul_div_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ctor_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ctor_exp([NotNull] LuaParser.Table_ctor_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ctor_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ctor_exp([NotNull] LuaParser.Table_ctor_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_concat_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_concat_exp([NotNull] LuaParser.Op_concat_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_concat_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_concat_exp([NotNull] LuaParser.Op_concat_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>string_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_exp([NotNull] LuaParser.String_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_exp([NotNull] LuaParser.String_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>false_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFalse_exp([NotNull] LuaParser.False_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>false_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFalse_exp([NotNull] LuaParser.False_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_add_sub_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_add_sub_exp([NotNull] LuaParser.Op_add_sub_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_add_sub_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_add_sub_exp([NotNull] LuaParser.Op_add_sub_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nil_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNil_exp([NotNull] LuaParser.Nil_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nil_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNil_exp([NotNull] LuaParser.Nil_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_unary_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_unary_exp([NotNull] LuaParser.Op_unary_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_unary_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_unary_exp([NotNull] LuaParser.Op_unary_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>op_caompare_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOp_caompare_exp([NotNull] LuaParser.Op_caompare_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>op_caompare_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOp_caompare_exp([NotNull] LuaParser.Op_caompare_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>true_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrue_exp([NotNull] LuaParser.True_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>true_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrue_exp([NotNull] LuaParser.True_expContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>func_def_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_def_exp([NotNull] LuaParser.Func_def_expContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>func_def_exp</c>
	/// labeled alternative in <see cref="LuaParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_def_exp([NotNull] LuaParser.Func_def_expContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.prefixexp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixexp([NotNull] LuaParser.PrefixexpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.prefixexp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixexp([NotNull] LuaParser.PrefixexpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.functioncall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctioncall([NotNull] LuaParser.FunctioncallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.functioncall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctioncall([NotNull] LuaParser.FunctioncallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.varOrExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrExp([NotNull] LuaParser.VarOrExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.varOrExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrExp([NotNull] LuaParser.VarOrExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar([NotNull] LuaParser.VarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar([NotNull] LuaParser.VarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.varSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarSuffix([NotNull] LuaParser.VarSuffixContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.varSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarSuffix([NotNull] LuaParser.VarSuffixContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.nameAndArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameAndArgs([NotNull] LuaParser.NameAndArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.nameAndArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameAndArgs([NotNull] LuaParser.NameAndArgsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgs([NotNull] LuaParser.ArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgs([NotNull] LuaParser.ArgsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.functiondef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctiondef([NotNull] LuaParser.FunctiondefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.functiondef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctiondef([NotNull] LuaParser.FunctiondefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.funcbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncbody([NotNull] LuaParser.FuncbodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.funcbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncbody([NotNull] LuaParser.FuncbodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.parlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParlist([NotNull] LuaParser.ParlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.parlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParlist([NotNull] LuaParser.ParlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.tableconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableconstructor([NotNull] LuaParser.TableconstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.tableconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableconstructor([NotNull] LuaParser.TableconstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.fieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldlist([NotNull] LuaParser.FieldlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.fieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldlist([NotNull] LuaParser.FieldlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] LuaParser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] LuaParser.FieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.fieldsep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldsep([NotNull] LuaParser.FieldsepContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.fieldsep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldsep([NotNull] LuaParser.FieldsepContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorOr([NotNull] LuaParser.OperatorOrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorOr([NotNull] LuaParser.OperatorOrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorAnd([NotNull] LuaParser.OperatorAndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorAnd([NotNull] LuaParser.OperatorAndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorComparison([NotNull] LuaParser.OperatorComparisonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorStrcat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorStrcat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorStrcat([NotNull] LuaParser.OperatorStrcatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorAddSub([NotNull] LuaParser.OperatorAddSubContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorMulDivMod([NotNull] LuaParser.OperatorMulDivModContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorBitwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorBitwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorBitwise([NotNull] LuaParser.OperatorBitwiseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorUnary([NotNull] LuaParser.OperatorUnaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.operatorPower"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorPower([NotNull] LuaParser.OperatorPowerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.operatorPower"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorPower([NotNull] LuaParser.OperatorPowerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] LuaParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] LuaParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LuaParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] LuaParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LuaParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] LuaParser.StringContext context);
}
} // namespace _gen
