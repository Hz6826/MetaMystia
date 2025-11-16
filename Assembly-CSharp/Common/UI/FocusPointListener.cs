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

namespace Common.UI
{
	// Token: 0x02000386 RID: 902
	public class FocusPointListener : Object
	{
		// Token: 0x06006B2E RID: 27438 RVA: 0x00204038 File Offset: 0x00202238
		// Note: this type is marked as 'beforefieldinit'.
		static FocusPointListener()
		{
			Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "FocusPointListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr);
			FocusPointListener.NativeFieldInfoPtr__asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "<asset>k__BackingField");
			FocusPointListener.NativeFieldInfoPtr_m_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "m_Persistent");
			FocusPointListener.NativeFieldInfoPtr_m_PersistentActionsCallbackInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "m_PersistentActionsCallbackInterface");
			FocusPointListener.NativeFieldInfoPtr_m_Persistent_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "m_Persistent_Move");
			FocusPointListener.NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685436);
			FocusPointListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685437);
			FocusPointListener.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685438);
			FocusPointListener.NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685439);
			FocusPointListener.NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685440);
			FocusPointListener.NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685441);
			FocusPointListener.NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685442);
			FocusPointListener.NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685443);
			FocusPointListener.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685444);
			FocusPointListener.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685445);
			FocusPointListener.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685446);
			FocusPointListener.NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685447);
			FocusPointListener.NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685448);
			FocusPointListener.NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685449);
			FocusPointListener.NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685450);
			FocusPointListener.NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685451);
			FocusPointListener.NativeMethodInfoPtr_get_Persistent_Public_get_PersistentActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, 100685452);
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x0020420C File Offset: 0x0020240C
		public unsafe InputActionAsset asset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x0020424C File Offset: 0x0020244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271890, XrefRangeEnd = 271904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusPointListener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00204288 File Offset: 0x00202488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271904, XrefRangeEnd = 271908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x06006B32 RID: 27442 RVA: 0x002042BC File Offset: 0x002024BC
		// (set) Token: 0x06006B33 RID: 27443 RVA: 0x002042F4 File Offset: 0x002024F4
		public unsafe virtual Nullable<InputBinding> bindingMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<InputBinding>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06006B34 RID: 27444 RVA: 0x0020433C File Offset: 0x0020253C
		// (set) Token: 0x06006B35 RID: 27445 RVA: 0x00204374 File Offset: 0x00202574
		public unsafe virtual Nullable<ReadOnlyArray<InputDevice>> devices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<ReadOnlyArray<InputDevice>>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06006B36 RID: 27446 RVA: 0x002043BC File Offset: 0x002025BC
		public unsafe virtual ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ReadOnlyArray<InputControlScheme>(pointer);
			}
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x002043F4 File Offset: 0x002025F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x00204444 File Offset: 0x00202644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<InputAction> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<InputAction>>(intPtr3) : null;
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00204484 File Offset: 0x00202684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x002044C4 File Offset: 0x002026C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x002044F8 File Offset: 0x002026F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06006B3C RID: 27452 RVA: 0x0020452C File Offset: 0x0020272C
		public unsafe virtual IEnumerable<InputBinding> bindings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x0020456C File Offset: 0x0020276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionNameOrId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwIfNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x002045CC File Offset: 0x002027CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bindingMask));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x00204644 File Offset: 0x00202844
		public unsafe FocusPointListener.PersistentActions Persistent
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 255328, RefRangeEnd = 255368, XrefRangeStart = 255328, XrefRangeEnd = 255368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.NativeMethodInfoPtr_get_Persistent_Public_get_PersistentActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new FocusPointListener.PersistentActions(pointer);
			}
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x0003A04B File Offset: 0x0003824B
		public FocusPointListener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x06006B41 RID: 27457 RVA: 0x0020467C File Offset: 0x0020287C
		// (set) Token: 0x06006B42 RID: 27458 RVA: 0x0003A054 File Offset: 0x00038254
		public unsafe InputActionAsset _asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr__asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr__asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x06006B43 RID: 27459 RVA: 0x002046AC File Offset: 0x002028AC
		// (set) Token: 0x06006B44 RID: 27460 RVA: 0x0003A073 File Offset: 0x00038273
		public unsafe InputActionMap m_Persistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_Persistent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_Persistent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x002046DC File Offset: 0x002028DC
		// (set) Token: 0x06006B46 RID: 27462 RVA: 0x0003A092 File Offset: 0x00038292
		public unsafe FocusPointListener.IPersistentActions m_PersistentActionsCallbackInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_PersistentActionsCallbackInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusPointListener.IPersistentActions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_PersistentActionsCallbackInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x06006B47 RID: 27463 RVA: 0x0020470C File Offset: 0x0020290C
		// (set) Token: 0x06006B48 RID: 27464 RVA: 0x0003A0B1 File Offset: 0x000382B1
		public unsafe InputAction m_Persistent_Move
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_Persistent_Move);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.NativeFieldInfoPtr_m_Persistent_Move), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400470B RID: 18187
		private static readonly IntPtr NativeFieldInfoPtr__asset_k__BackingField;

		// Token: 0x0400470C RID: 18188
		private static readonly IntPtr NativeFieldInfoPtr_m_Persistent;

		// Token: 0x0400470D RID: 18189
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentActionsCallbackInterface;

		// Token: 0x0400470E RID: 18190
		private static readonly IntPtr NativeFieldInfoPtr_m_Persistent_Move;

		// Token: 0x0400470F RID: 18191
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_InputActionAsset_0;

		// Token: 0x04004710 RID: 18192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004711 RID: 18193
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004712 RID: 18194
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingMask_Public_Virtual_Final_New_get_Nullable_1_InputBinding_0;

		// Token: 0x04004713 RID: 18195
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingMask_Public_Virtual_Final_New_set_Void_Nullable_1_InputBinding_0;

		// Token: 0x04004714 RID: 18196
		private static readonly IntPtr NativeMethodInfoPtr_get_devices_Public_Virtual_Final_New_get_Nullable_1_ReadOnlyArray_1_InputDevice_0;

		// Token: 0x04004715 RID: 18197
		private static readonly IntPtr NativeMethodInfoPtr_set_devices_Public_Virtual_Final_New_set_Void_Nullable_1_ReadOnlyArray_1_InputDevice_0;

		// Token: 0x04004716 RID: 18198
		private static readonly IntPtr NativeMethodInfoPtr_get_controlSchemes_Public_Virtual_Final_New_get_ReadOnlyArray_1_InputControlScheme_0;

		// Token: 0x04004717 RID: 18199
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_InputAction_0;

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_InputAction_0;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeMethodInfoPtr_get_bindings_Public_Virtual_Final_New_get_IEnumerable_1_InputBinding_0;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeMethodInfoPtr_FindAction_Public_Virtual_Final_New_InputAction_String_Boolean_0;

		// Token: 0x0400471E RID: 18206
		private static readonly IntPtr NativeMethodInfoPtr_FindBinding_Public_Virtual_Final_New_Int32_InputBinding_byref_InputAction_0;

		// Token: 0x0400471F RID: 18207
		private static readonly IntPtr NativeMethodInfoPtr_get_Persistent_Public_get_PersistentActions_0;

		// Token: 0x02000EA5 RID: 3749
		public sealed class PersistentActions : ValueType
		{
			// Token: 0x0601092F RID: 67887 RVA: 0x003D7220 File Offset: 0x003D5420
			// Note: this type is marked as 'beforefieldinit'.
			static PersistentActions()
			{
				Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "PersistentActions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr);
				FocusPointListener.PersistentActions.NativeFieldInfoPtr_m_Wrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, "m_Wrapper");
				FocusPointListener.PersistentActions.NativeMethodInfoPtr__ctor_Public_Void_FocusPointListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685453);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_get_Move_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685454);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_Get_Public_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685455);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685456);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685457);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685458);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_PersistentActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685459);
				FocusPointListener.PersistentActions.NativeMethodInfoPtr_SetCallbacks_Public_Void_IPersistentActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr, 100685460);
			}

			// Token: 0x06010930 RID: 67888 RVA: 0x003D7300 File Offset: 0x003D5500
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2767, XrefRangeEnd = 2776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PersistentActions(FocusPointListener wrapper) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr__ctor_Public_Void_FocusPointListener_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005679 RID: 22137
			// (get) Token: 0x06010931 RID: 67889 RVA: 0x003D7350 File Offset: 0x003D5550
			public unsafe InputAction Move
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_get_Move_Public_get_InputAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
				}
			}

			// Token: 0x06010932 RID: 67890 RVA: 0x003D7394 File Offset: 0x003D5594
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 186213, RefRangeEnd = 186220, XrefRangeStart = 186213, XrefRangeEnd = 186220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputActionMap Get()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_Get_Public_InputActionMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr3) : null;
			}

			// Token: 0x06010933 RID: 67891 RVA: 0x003D73D8 File Offset: 0x003D55D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Enable()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010934 RID: 67892 RVA: 0x003D7410 File Offset: 0x003D5610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Disable()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700567A RID: 22138
			// (get) Token: 0x06010935 RID: 67893 RVA: 0x003D7448 File Offset: 0x003D5648
			public unsafe bool enabled
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010936 RID: 67894 RVA: 0x003D748C File Offset: 0x003D568C
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 255175, RefRangeEnd = 255213, XrefRangeStart = 255175, XrefRangeEnd = 255213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator InputActionMap(FocusPointListener.PersistentActions set)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(set));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_PersistentActions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr3) : null;
			}

			// Token: 0x06010937 RID: 67895 RVA: 0x003D74D8 File Offset: 0x003D56D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271851, XrefRangeEnd = 271890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetCallbacks(FocusPointListener.IPersistentActions instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusPointListener.PersistentActions.NativeMethodInfoPtr_SetCallbacks_Public_Void_IPersistentActions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010938 RID: 67896 RVA: 0x00090AAC File Offset: 0x0008ECAC
			public PersistentActions(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010939 RID: 67897 RVA: 0x00090AB5 File Offset: 0x0008ECB5
			public PersistentActions() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusPointListener.PersistentActions>.NativeClassPtr))
			{
			}

			// Token: 0x17005678 RID: 22136
			// (get) Token: 0x0601093A RID: 67898 RVA: 0x003D7520 File Offset: 0x003D5720
			// (set) Token: 0x0601093B RID: 67899 RVA: 0x00090AC7 File Offset: 0x0008ECC7
			public unsafe FocusPointListener m_Wrapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.PersistentActions.NativeFieldInfoPtr_m_Wrapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusPointListener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusPointListener.PersistentActions.NativeFieldInfoPtr_m_Wrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7B6 RID: 42934
			private static readonly IntPtr NativeFieldInfoPtr_m_Wrapper;

			// Token: 0x0400A7B7 RID: 42935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FocusPointListener_0;

			// Token: 0x0400A7B8 RID: 42936
			private static readonly IntPtr NativeMethodInfoPtr_get_Move_Public_get_InputAction_0;

			// Token: 0x0400A7B9 RID: 42937
			private static readonly IntPtr NativeMethodInfoPtr_Get_Public_InputActionMap_0;

			// Token: 0x0400A7BA RID: 42938
			private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

			// Token: 0x0400A7BB RID: 42939
			private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

			// Token: 0x0400A7BC RID: 42940
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x0400A7BD RID: 42941
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InputActionMap_PersistentActions_0;

			// Token: 0x0400A7BE RID: 42942
			private static readonly IntPtr NativeMethodInfoPtr_SetCallbacks_Public_Void_IPersistentActions_0;
		}

		// Token: 0x02000EA6 RID: 3750
		public class IPersistentActions : Il2CppObjectBase
		{
			// Token: 0x0601093C RID: 67900 RVA: 0x00090AE6 File Offset: 0x0008ECE6
			// Note: this type is marked as 'beforefieldinit'.
			static IPersistentActions()
			{
				Il2CppClassPointerStore<FocusPointListener.IPersistentActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusPointListener>.NativeClassPtr, "IPersistentActions");
				FocusPointListener.IPersistentActions.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusPointListener.IPersistentActions>.NativeClassPtr, 100685461);
			}

			// Token: 0x0601093D RID: 67901 RVA: 0x003D7550 File Offset: 0x003D5750
			[CallerCount(0)]
			public unsafe virtual void OnMove(InputAction.CallbackContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusPointListener.IPersistentActions.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_CallbackContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601093E RID: 67902 RVA: 0x00090B10 File Offset: 0x0008ED10
			public IPersistentActions(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400A7BF RID: 42943
			private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_CallbackContext_0;
		}
	}
}
