using System;
using System.Runtime.InteropServices;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200018A RID: 394
	public class MultipleInteractionsBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x0012C77C File Offset: 0x0012A97C
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleInteractionsBehaviourComponent()
		{
			Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MultipleInteractionsBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr);
			MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "characterLabel");
			MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "_actions");
			MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "<Id>k__BackingField");
			MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__CurrentIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "<CurrentIndex>k__BackingField");
			MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__MaxIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "<MaxIndex>k__BackingField");
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670728);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_Id_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670729);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_CurrentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670730);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_CurrentIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670731);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_MaxIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670732);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_MaxIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670733);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670734);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670735);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670736);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670737);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Init_Protected_Void_String_Int32_Int32_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670738);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Execute_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670739);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OpenShop_Protected_Virtual_New_Void_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670740);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_PlayDialog_Protected_Virtual_New_Void_DialogPackage_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670741);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670742);
			MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, 100670743);
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0012C950 File Offset: 0x0012AB50
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0012C988 File Offset: 0x0012AB88
		public unsafe string Id
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_Id_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0012C9CC File Offset: 0x0012ABCC
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0012CA08 File Offset: 0x0012AC08
		public unsafe int CurrentIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_CurrentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95701, RefRangeEnd = 95702, XrefRangeStart = 95701, XrefRangeEnd = 95701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_CurrentIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0012CA48 File Offset: 0x0012AC48
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0012CA84 File Offset: 0x0012AC84
		public unsafe int MaxIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73634, RefRangeEnd = 73635, XrefRangeStart = 73634, XrefRangeEnd = 73635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_get_MaxIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_set_MaxIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0012CAC4 File Offset: 0x0012ACC4
		[CallerCount(0)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0012CB00 File Offset: 0x0012AD00
		[CallerCount(0)]
		public unsafe virtual void Interact()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x0012CB3C File Offset: 0x0012AD3C
		[CallerCount(0)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x0012CB78 File Offset: 0x0012AD78
		[CallerCount(0)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0012CBB4 File Offset: 0x0012ADB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95710, RefRangeEnd = 95712, XrefRangeStart = 95702, XrefRangeEnd = 95710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string id, int currentIndex, int maxIndex, [Optional] Il2CppReferenceArray<Action> tasks)
		{
			if (tasks == null)
			{
				tasks = new Il2CppReferenceArray<Action>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tasks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Init_Protected_Void_String_Int32_Int32_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0012CC34 File Offset: 0x0012AE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95718, RefRangeEnd = 95720, XrefRangeStart = 95712, XrefRangeEnd = 95718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Execute_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0012CC68 File Offset: 0x0012AE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95720, XrefRangeEnd = 95772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OpenShop(DialogPackage dialogPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_OpenShop_Protected_Virtual_New_Void_DialogPackage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0012CCB8 File Offset: 0x0012AEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95772, XrefRangeEnd = 95776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayDialog(DialogPackage dialogPackage, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_PlayDialog_Protected_Virtual_New_Void_DialogPackage_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x0012CD18 File Offset: 0x0012AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95776, XrefRangeEnd = 95781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0012CD54 File Offset: 0x0012AF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95790, RefRangeEnd = 95792, XrefRangeStart = 95781, XrefRangeEnd = 95790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleInteractionsBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00018F6E File Offset: 0x0001716E
		public void Init(string id, int currentIndex, int maxIndex, params Action[] tasks)
		{
			this.Init(id, currentIndex, maxIndex, new Il2CppReferenceArray<Action>(tasks));
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00018F80 File Offset: 0x00017180
		public MultipleInteractionsBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x0012CD90 File Offset: 0x0012AF90
		// (set) Token: 0x06002ADA RID: 10970 RVA: 0x00018F89 File Offset: 0x00017189
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0012CDB8 File Offset: 0x0012AFB8
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x00018FA8 File Offset: 0x000171A8
		public unsafe Dictionary<int, Action> _actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0012CDE8 File Offset: 0x0012AFE8
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x00018FC7 File Offset: 0x000171C7
		public unsafe string _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__Id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0012CE10 File Offset: 0x0012B010
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x00018FE6 File Offset: 0x000171E6
		public unsafe int _CurrentIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__CurrentIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__CurrentIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x0012CE38 File Offset: 0x0012B038
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x00019001 File Offset: 0x00017201
		public unsafe int _MaxIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__MaxIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.NativeFieldInfoPtr__MaxIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr__actions;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr__CurrentIndex_k__BackingField;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr__MaxIndex_k__BackingField;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Private_set_Void_String_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentIndex_Public_get_Int32_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentIndex_Private_set_Void_Int32_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxIndex_Public_get_Int32_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxIndex_Private_set_Void_Int32_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_Interact_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_String_Int32_Int32_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Void_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_OpenShop_Protected_Virtual_New_Void_DialogPackage_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_PlayDialog_Protected_Virtual_New_Void_DialogPackage_Action_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020007BF RID: 1983
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MultipleInteractionsBehaviourComponent+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x0600A577 RID: 42359 RVA: 0x002B33CC File Offset: 0x002B15CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr);
				MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_merchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, "merchant");
				MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670744);
				MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr, 100670745);
			}

			// Token: 0x0600A578 RID: 42360 RVA: 0x002B3434 File Offset: 0x002B1634
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A579 RID: 42361 RVA: 0x002B3470 File Offset: 0x002B1670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95681, XrefRangeEnd = 95701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenShop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A57A RID: 42362 RVA: 0x00059782 File Offset: 0x00057982
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700367F RID: 13951
			// (get) Token: 0x0600A57B RID: 42363 RVA: 0x002B34A4 File Offset: 0x002B16A4
			// (set) Token: 0x0600A57C RID: 42364 RVA: 0x0005978B File Offset: 0x0005798B
			public unsafe TrackedMerchant merchant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_merchant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleInteractionsBehaviourComponent.__c__DisplayClass20_0.NativeFieldInfoPtr_merchant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AFF RID: 27391
			private static readonly IntPtr NativeFieldInfoPtr_merchant;

			// Token: 0x04006B00 RID: 27392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B01 RID: 27393
			private static readonly IntPtr NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0;
		}

		// Token: 0x020007C0 RID: 1984
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MultipleInteractionsBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A57D RID: 42365 RVA: 0x002B34D4 File Offset: 0x002B16D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr);
				MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, "<>9");
				MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, "<>9__20_2");
				MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, "<>9__20_1");
				MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, 100670747);
				MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__OpenShop_b__20_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, 100670748);
				MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__OpenShop_b__20_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr, 100670749);
			}

			// Token: 0x0600A57E RID: 42366 RVA: 0x002B3578 File Offset: 0x002B1778
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleInteractionsBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A57F RID: 42367 RVA: 0x002B35B4 File Offset: 0x002B17B4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenShop_b__20_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__OpenShop_b__20_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A580 RID: 42368 RVA: 0x002B35E8 File Offset: 0x002B17E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenShop_b__20_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleInteractionsBehaviourComponent.__c.NativeMethodInfoPtr__OpenShop_b__20_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A581 RID: 42369 RVA: 0x000597AA File Offset: 0x000579AA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003680 RID: 13952
			// (get) Token: 0x0600A582 RID: 42370 RVA: 0x002B361C File Offset: 0x002B181C
			// (set) Token: 0x0600A583 RID: 42371 RVA: 0x000597B3 File Offset: 0x000579B3
			public unsafe static MultipleInteractionsBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleInteractionsBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003681 RID: 13953
			// (get) Token: 0x0600A584 RID: 42372 RVA: 0x002B3644 File Offset: 0x002B1844
			// (set) Token: 0x0600A585 RID: 42373 RVA: 0x000597C5 File Offset: 0x000579C5
			public unsafe static Action __9__20_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003682 RID: 13954
			// (get) Token: 0x0600A586 RID: 42374 RVA: 0x002B366C File Offset: 0x002B186C
			// (set) Token: 0x0600A587 RID: 42375 RVA: 0x000597D7 File Offset: 0x000579D7
			public unsafe static Action __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultipleInteractionsBehaviourComponent.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B02 RID: 27394
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006B03 RID: 27395
			private static readonly IntPtr NativeFieldInfoPtr___9__20_2;

			// Token: 0x04006B04 RID: 27396
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x04006B05 RID: 27397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B06 RID: 27398
			private static readonly IntPtr NativeMethodInfoPtr__OpenShop_b__20_2_Internal_Void_0;

			// Token: 0x04006B07 RID: 27399
			private static readonly IntPtr NativeMethodInfoPtr__OpenShop_b__20_1_Internal_Void_0;
		}
	}
}
