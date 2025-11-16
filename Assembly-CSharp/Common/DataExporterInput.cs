using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Common
{
	// Token: 0x0200033D RID: 829
	public class DataExporterInput : Object
	{
		// Token: 0x0600629D RID: 25245 RVA: 0x001E8044 File Offset: 0x001E6244
		// Note: this type is marked as 'beforefieldinit'.
		static DataExporterInput()
		{
			Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "DataExporterInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr);
			DataExporterInput.NativeFieldInfoPtr__asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "<asset>k__BackingField");
			DataExporterInput.NativeFieldInfoPtr_m_Universal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "m_Universal");
			DataExporterInput.NativeFieldInfoPtr_m_UniversalActionsCallbackInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "m_UniversalActionsCallbackInterface");
			DataExporterInput.NativeFieldInfoPtr_m_Universal_Export = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "m_Universal_Export");
			DataExporterInput.NativeFieldInfoPtr_m_Universal_SkipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "m_Universal_SkipButton");
			DataExporterInput.NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684044);
			DataExporterInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684045);
			DataExporterInput.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684046);
			DataExporterInput.NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684047);
			DataExporterInput.NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684048);
			DataExporterInput.NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684049);
			DataExporterInput.NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684050);
			DataExporterInput.NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684051);
			DataExporterInput.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684052);
			DataExporterInput.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684053);
			DataExporterInput.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684054);
			DataExporterInput.NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684055);
			DataExporterInput.NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684056);
			DataExporterInput.NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684057);
			DataExporterInput.NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684058);
			DataExporterInput.NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684059);
			DataExporterInput.NativeMethodInfoPtr_get_Universal_Public_get_UniversalActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, 100684060);
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x001E822C File Offset: 0x001E642C
		public unsafe InputActionAsset asset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr3) : null;
			}
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x001E826C File Offset: 0x001E646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255288, XrefRangeEnd = 255306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataExporterInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x001E82A8 File Offset: 0x001E64A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255306, XrefRangeEnd = 255310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x001E82DC File Offset: 0x001E64DC
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x001E8314 File Offset: 0x001E6514
		public unsafe virtual Nullable<InputBinding> bindingMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<InputBinding>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255310, XrefRangeEnd = 255311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x001E835C File Offset: 0x001E655C
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x001E8394 File Offset: 0x001E6594
		public unsafe virtual Nullable<ReadOnlyArray<InputDevice>> devices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255311, XrefRangeEnd = 255312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<ReadOnlyArray<InputDevice>>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255312, XrefRangeEnd = 255313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x001E83DC File Offset: 0x001E65DC
		public unsafe virtual ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255313, XrefRangeEnd = 255314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<InputControlScheme>(pointer);
			}
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x001E8414 File Offset: 0x001E6614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255314, XrefRangeEnd = 255316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x001E8464 File Offset: 0x001E6664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255316, XrefRangeEnd = 255318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<InputAction> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<InputAction>>(intPtr3) : null;
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x001E84A4 File Offset: 0x001E66A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x001E84E4 File Offset: 0x001E66E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255318, XrefRangeEnd = 255320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x001E8518 File Offset: 0x001E6718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255320, XrefRangeEnd = 255322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x060062AB RID: 25259 RVA: 0x001E854C File Offset: 0x001E674C
		public unsafe virtual IEnumerable<InputBinding> bindings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255322, XrefRangeEnd = 255324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x001E858C File Offset: 0x001E678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255324, XrefRangeEnd = 255326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionNameOrId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwIfNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x001E85EC File Offset: 0x001E67EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255326, XrefRangeEnd = 255327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bindingMask));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x060062AE RID: 25262 RVA: 0x001E8664 File Offset: 0x001E6864
		public unsafe DataExporterInput.UniversalActions Universal
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 255328, RefRangeEnd = 255368, XrefRangeStart = 255327, XrefRangeEnd = 255328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.NativeMethodInfoPtr_get_Universal_Public_get_UniversalActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DataExporterInput.UniversalActions(pointer);
			}
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x0003549E File Offset: 0x0003369E
		public DataExporterInput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x060062B0 RID: 25264 RVA: 0x001E869C File Offset: 0x001E689C
		// (set) Token: 0x060062B1 RID: 25265 RVA: 0x000354A7 File Offset: 0x000336A7
		public unsafe InputActionAsset _asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr__asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr__asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x060062B2 RID: 25266 RVA: 0x001E86CC File Offset: 0x001E68CC
		// (set) Token: 0x060062B3 RID: 25267 RVA: 0x000354C6 File Offset: 0x000336C6
		public unsafe InputActionMap m_Universal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x060062B4 RID: 25268 RVA: 0x001E86FC File Offset: 0x001E68FC
		// (set) Token: 0x060062B5 RID: 25269 RVA: 0x000354E5 File Offset: 0x000336E5
		public unsafe DataExporterInput.IUniversalActions m_UniversalActionsCallbackInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_UniversalActionsCallbackInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataExporterInput.IUniversalActions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_UniversalActionsCallbackInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x060062B6 RID: 25270 RVA: 0x001E872C File Offset: 0x001E692C
		// (set) Token: 0x060062B7 RID: 25271 RVA: 0x00035504 File Offset: 0x00033704
		public unsafe InputAction m_Universal_Export
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal_Export);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal_Export), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x060062B8 RID: 25272 RVA: 0x001E875C File Offset: 0x001E695C
		// (set) Token: 0x060062B9 RID: 25273 RVA: 0x00035523 File Offset: 0x00033723
		public unsafe InputAction m_Universal_SkipButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal_SkipButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.NativeFieldInfoPtr_m_Universal_SkipButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400415D RID: 16733
		private static readonly IntPtr NativeFieldInfoPtr__asset_k__BackingField;

		// Token: 0x0400415E RID: 16734
		private static readonly IntPtr NativeFieldInfoPtr_m_Universal;

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeFieldInfoPtr_m_UniversalActionsCallbackInterface;

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeFieldInfoPtr_m_Universal_Export;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeFieldInfoPtr_m_Universal_SkipButton;

		// Token: 0x04004162 RID: 16738
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0;

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0;

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0;

		// Token: 0x04004168 RID: 16744
		private static readonly IntPtr NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0;

		// Token: 0x04004169 RID: 16745
		private static readonly IntPtr NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0;

		// Token: 0x0400416A RID: 16746
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0;

		// Token: 0x0400416B RID: 16747
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0;

		// Token: 0x0400416C RID: 16748
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400416D RID: 16749
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400416E RID: 16750
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400416F RID: 16751
		private static readonly IntPtr NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0;

		// Token: 0x04004170 RID: 16752
		private static readonly IntPtr NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0;

		// Token: 0x04004171 RID: 16753
		private static readonly IntPtr NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0;

		// Token: 0x04004172 RID: 16754
		private static readonly IntPtr NativeMethodInfoPtr_get_Universal_Public_get_UniversalActions_0;

		// Token: 0x02000DF0 RID: 3568
		public sealed class UniversalActions : ValueType
		{
			// Token: 0x06010150 RID: 65872 RVA: 0x003C1254 File Offset: 0x003BF454
			// Note: this type is marked as 'beforefieldinit'.
			static UniversalActions()
			{
				Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "UniversalActions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr);
				DataExporterInput.UniversalActions.NativeFieldInfoPtr_m_Wrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, "m_Wrapper");
				DataExporterInput.UniversalActions.NativeMethodInfoPtr__ctor_Public_Void_DataExporterInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684061);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_Export_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684062);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_SkipButton_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684063);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_Get_Public_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684064);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684065);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684066);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684067);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_UniversalActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684068);
				DataExporterInput.UniversalActions.NativeMethodInfoPtr_SetCallbacks_Public_Void_IUniversalActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr, 100684069);
			}

			// Token: 0x06010151 RID: 65873 RVA: 0x003C1348 File Offset: 0x003BF548
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2767, XrefRangeEnd = 2776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniversalActions(DataExporterInput wrapper) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr__ctor_Public_Void_DataExporterInput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700540F RID: 21519
			// (get) Token: 0x06010152 RID: 65874 RVA: 0x003C1398 File Offset: 0x003BF598
			public unsafe InputAction Export
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_Export_Public_get_InputAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
				}
			}

			// Token: 0x17005410 RID: 21520
			// (get) Token: 0x06010153 RID: 65875 RVA: 0x003C13DC File Offset: 0x003BF5DC
			public unsafe InputAction SkipButton
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_SkipButton_Public_get_InputAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
				}
			}

			// Token: 0x06010154 RID: 65876 RVA: 0x003C1420 File Offset: 0x003BF620
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 186213, RefRangeEnd = 186220, XrefRangeStart = 186213, XrefRangeEnd = 186220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputActionMap Get()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_Get_Public_InputActionMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr3) : null;
			}

			// Token: 0x06010155 RID: 65877 RVA: 0x003C1464 File Offset: 0x003BF664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255169, XrefRangeEnd = 255171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Enable()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010156 RID: 65878 RVA: 0x003C149C File Offset: 0x003BF69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255171, XrefRangeEnd = 255173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Disable()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005411 RID: 21521
			// (get) Token: 0x06010157 RID: 65879 RVA: 0x003C14D4 File Offset: 0x003BF6D4
			public unsafe bool enabled
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255173, XrefRangeEnd = 255175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010158 RID: 65880 RVA: 0x003C1518 File Offset: 0x003BF718
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 255175, RefRangeEnd = 255213, XrefRangeStart = 255175, XrefRangeEnd = 255175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator InputActionMap(DataExporterInput.UniversalActions set)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(set));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_UniversalActions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr3) : null;
			}

			// Token: 0x06010159 RID: 65881 RVA: 0x003C1564 File Offset: 0x003BF764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255213, XrefRangeEnd = 255288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetCallbacks(DataExporterInput.IUniversalActions instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporterInput.UniversalActions.NativeMethodInfoPtr_SetCallbacks_Public_Void_IUniversalActions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601015A RID: 65882 RVA: 0x0008BD80 File Offset: 0x00089F80
			public UniversalActions(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601015B RID: 65883 RVA: 0x0008BD89 File Offset: 0x00089F89
			public UniversalActions() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExporterInput.UniversalActions>.NativeClassPtr))
			{
			}

			// Token: 0x1700540E RID: 21518
			// (get) Token: 0x0601015C RID: 65884 RVA: 0x003C15AC File Offset: 0x003BF7AC
			// (set) Token: 0x0601015D RID: 65885 RVA: 0x0008BD9B File Offset: 0x00089F9B
			public unsafe DataExporterInput m_Wrapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.UniversalActions.NativeFieldInfoPtr_m_Wrapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataExporterInput>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporterInput.UniversalActions.NativeFieldInfoPtr_m_Wrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A344 RID: 41796
			private static readonly IntPtr NativeFieldInfoPtr_m_Wrapper;

			// Token: 0x0400A345 RID: 41797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataExporterInput_0;

			// Token: 0x0400A346 RID: 41798
			private static readonly IntPtr NativeMethodInfoPtr_get_Export_Public_get_InputAction_0;

			// Token: 0x0400A347 RID: 41799
			private static readonly IntPtr NativeMethodInfoPtr_get_SkipButton_Public_get_InputAction_0;

			// Token: 0x0400A348 RID: 41800
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_InputActionMap_0;

			// Token: 0x0400A349 RID: 41801
			private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

			// Token: 0x0400A34A RID: 41802
			private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

			// Token: 0x0400A34B RID: 41803
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x0400A34C RID: 41804
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_UniversalActions_0;

			// Token: 0x0400A34D RID: 41805
			private static readonly IntPtr NativeMethodInfoPtr_SetCallbacks_Public_Void_IUniversalActions_0;
		}

		// Token: 0x02000DF1 RID: 3569
		public class IUniversalActions : Il2CppObjectBase
		{
			// Token: 0x0601015E RID: 65886 RVA: 0x0008BDBA File Offset: 0x00089FBA
			// Note: this type is marked as 'beforefieldinit'.
			static IUniversalActions()
			{
				Il2CppClassPointerStore<DataExporterInput.IUniversalActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataExporterInput>.NativeClassPtr, "IUniversalActions");
				DataExporterInput.IUniversalActions.NativeMethodInfoPtr_OnExport_Public_Abstract_Virtual_New_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.IUniversalActions>.NativeClassPtr, 100684070);
				DataExporterInput.IUniversalActions.NativeMethodInfoPtr_OnSkipButton_Public_Abstract_Virtual_New_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporterInput.IUniversalActions>.NativeClassPtr, 100684071);
			}

			// Token: 0x0601015F RID: 65887 RVA: 0x003C15DC File Offset: 0x003BF7DC
			[CallerCount(0)]
			public unsafe virtual void OnExport(InputAction.CallbackContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataExporterInput.IUniversalActions.NativeMethodInfoPtr_OnExport_Public_Abstract_Virtual_New_Void_CallbackContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010160 RID: 65888 RVA: 0x003C1630 File Offset: 0x003BF830
			[CallerCount(0)]
			public unsafe virtual void OnSkipButton(InputAction.CallbackContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataExporterInput.IUniversalActions.NativeMethodInfoPtr_OnSkipButton_Public_Abstract_Virtual_New_Void_CallbackContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010161 RID: 65889 RVA: 0x0008BDF8 File Offset: 0x00089FF8
			public IUniversalActions(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400A34E RID: 41806
			private static readonly IntPtr NativeMethodInfoPtr_OnExport_Public_Abstract_Virtual_New_Void_CallbackContext_0;

			// Token: 0x0400A34F RID: 41807
			private static readonly IntPtr NativeMethodInfoPtr_OnSkipButton_Public_Abstract_Virtual_New_Void_CallbackContext_0;
		}
	}
}
