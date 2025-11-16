using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using TMPro;

namespace Common.UI
{
	// Token: 0x0200037C RID: 892
	public class LoadingErrorPannel : UIPanel
	{
		// Token: 0x060069CB RID: 27083 RVA: 0x001FFAC4 File Offset: 0x001FDCC4
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingErrorPannel()
		{
			Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "LoadingErrorPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr);
			LoadingErrorPannel.NativeFieldInfoPtr_m_ErrorMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, "m_ErrorMsg");
			LoadingErrorPannel.NativeFieldInfoPtr_m_QuitGameBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, "m_QuitGameBtn");
			LoadingErrorPannel.NativeFieldInfoPtr_m_StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, "m_StringBuilder");
			LoadingErrorPannel.NativeFieldInfoPtr__QuitOnExitPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, "<QuitOnExitPanel>k__BackingField");
			LoadingErrorPannel.NativeMethodInfoPtr_get_QuitOnExitPanel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685233);
			LoadingErrorPannel.NativeMethodInfoPtr_set_QuitOnExitPanel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685234);
			LoadingErrorPannel.NativeMethodInfoPtr_AddErrorMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685235);
			LoadingErrorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685236);
			LoadingErrorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685237);
			LoadingErrorPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685238);
			LoadingErrorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685239);
			LoadingErrorPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685240);
			LoadingErrorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, 100685241);
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x001FFBF8 File Offset: 0x001FDDF8
		// (set) Token: 0x060069CD RID: 27085 RVA: 0x001FFC34 File Offset: 0x001FDE34
		public unsafe bool QuitOnExitPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157691, RefRangeEnd = 157692, XrefRangeStart = 157691, XrefRangeEnd = 157692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr_get_QuitOnExitPanel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr_set_QuitOnExitPanel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x001FFC74 File Offset: 0x001FDE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269707, XrefRangeEnd = 269709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddErrorMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr_AddErrorMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x001FFCB8 File Offset: 0x001FDEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269709, XrefRangeEnd = 269718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingErrorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x001FFCF4 File Offset: 0x001FDEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269718, XrefRangeEnd = 269724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingErrorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x001FFD30 File Offset: 0x001FDF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269724, XrefRangeEnd = 269729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x001FFD6C File Offset: 0x001FDF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingErrorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x001FFDA8 File Offset: 0x001FDFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269729, XrefRangeEnd = 269736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingErrorPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x001FFDE4 File Offset: 0x001FDFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269736, XrefRangeEnd = 269740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__8_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel.NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x000392E8 File Offset: 0x000374E8
		public LoadingErrorPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x001FFE18 File Offset: 0x001FE018
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x000392F1 File Offset: 0x000374F1
		public unsafe TextMeshProUGUI m_ErrorMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_ErrorMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_ErrorMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001FFE48 File Offset: 0x001FE048
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x00039310 File Offset: 0x00037510
		public unsafe UIButtonSimple m_QuitGameBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_QuitGameBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_QuitGameBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x001FFE78 File Offset: 0x001FE078
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x0003932F File Offset: 0x0003752F
		public unsafe StringBuilder m_StringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_StringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr_m_StringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x001FFEA8 File Offset: 0x001FE0A8
		// (set) Token: 0x060069DD RID: 27101 RVA: 0x0003934E File Offset: 0x0003754E
		public unsafe bool _QuitOnExitPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr__QuitOnExitPanel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel.NativeFieldInfoPtr__QuitOnExitPanel_k__BackingField)) = value;
			}
		}

		// Token: 0x0400462A RID: 17962
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorMsg;

		// Token: 0x0400462B RID: 17963
		private static readonly IntPtr NativeFieldInfoPtr_m_QuitGameBtn;

		// Token: 0x0400462C RID: 17964
		private static readonly IntPtr NativeFieldInfoPtr_m_StringBuilder;

		// Token: 0x0400462D RID: 17965
		private static readonly IntPtr NativeFieldInfoPtr__QuitOnExitPanel_k__BackingField;

		// Token: 0x0400462E RID: 17966
		private static readonly IntPtr NativeMethodInfoPtr_get_QuitOnExitPanel_Public_get_Boolean_0;

		// Token: 0x0400462F RID: 17967
		private static readonly IntPtr NativeMethodInfoPtr_set_QuitOnExitPanel_Public_set_Void_Boolean_0;

		// Token: 0x04004630 RID: 17968
		private static readonly IntPtr NativeMethodInfoPtr_AddErrorMessage_Public_Void_String_0;

		// Token: 0x04004631 RID: 17969
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004632 RID: 17970
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004633 RID: 17971
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_UniTaskVoid_0;

		// Token: 0x04004634 RID: 17972
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004635 RID: 17973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004636 RID: 17974
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__8_0_Private_Void_0;

		// Token: 0x02000E8A RID: 3722
		[ObfuscatedName("Common.UI.LoadingErrorPannel+<OnPanelOpenAsync>d__10")]
		public sealed class _OnPanelOpenAsync_d__10 : ValueType
		{
			// Token: 0x0601081D RID: 67613 RVA: 0x003D3FA8 File Offset: 0x003D21A8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__10()
			{
				Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingErrorPannel>.NativeClassPtr, "<OnPanelOpenAsync>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr);
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, "<>1__state");
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, "<>t__builder");
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, "<>4__this");
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, "<>u__1");
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, 100685242);
				LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr, 100685243);
			}

			// Token: 0x0601081E RID: 67614 RVA: 0x003D404C File Offset: 0x003D224C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 269705, RefRangeEnd = 269707, XrefRangeStart = 269698, XrefRangeEnd = 269705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601081F RID: 67615 RVA: 0x003D4084 File Offset: 0x003D2284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010820 RID: 67616 RVA: 0x000901BD File Offset: 0x0008E3BD
			public _OnPanelOpenAsync_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010821 RID: 67617 RVA: 0x000901C6 File Offset: 0x0008E3C6
			public _OnPanelOpenAsync_d__10() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingErrorPannel._OnPanelOpenAsync_d__10>.NativeClassPtr))
			{
			}

			// Token: 0x1700562D RID: 22061
			// (get) Token: 0x06010822 RID: 67618 RVA: 0x003D40CC File Offset: 0x003D22CC
			// (set) Token: 0x06010823 RID: 67619 RVA: 0x000901D8 File Offset: 0x0008E3D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700562E RID: 22062
			// (get) Token: 0x06010824 RID: 67620 RVA: 0x003D40F4 File Offset: 0x003D22F4
			// (set) Token: 0x06010825 RID: 67621 RVA: 0x000901F3 File Offset: 0x0008E3F3
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700562F RID: 22063
			// (get) Token: 0x06010826 RID: 67622 RVA: 0x003D4124 File Offset: 0x003D2324
			// (set) Token: 0x06010827 RID: 67623 RVA: 0x00090221 File Offset: 0x0008E421
			public unsafe LoadingErrorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingErrorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005630 RID: 22064
			// (get) Token: 0x06010828 RID: 67624 RVA: 0x003D4154 File Offset: 0x003D2354
			// (set) Token: 0x06010829 RID: 67625 RVA: 0x00090240 File Offset: 0x0008E440
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingErrorPannel._OnPanelOpenAsync_d__10.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A717 RID: 42775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A718 RID: 42776
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A719 RID: 42777
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A71A RID: 42778
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A71B RID: 42779
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A71C RID: 42780
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
