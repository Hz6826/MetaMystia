using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.EventSystem.Spells.SpecialItem
{
	// Token: 0x02000053 RID: 83
	public class Yukari_Kima : MonoBehaviour
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x000C040C File Offset: 0x000BE60C
		// Note: this type is marked as 'beforefieldinit'.
		static Yukari_Kima()
		{
			Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.EventSystem.Spells.SpecialItem", "Yukari_Kima");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr);
			Yukari_Kima.NativeFieldInfoPtr_OnPlayerEnterKima = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, "OnPlayerEnterKima");
			Yukari_Kima.NativeFieldInfoPtr_OnKimaChangePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, "OnKimaChangePosition");
			Yukari_Kima.NativeFieldInfoPtr__CanBeTrigger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, "<CanBeTrigger>k__BackingField");
			Yukari_Kima.NativeFieldInfoPtr__WaitChangePositionTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, "<WaitChangePositionTime>k__BackingField");
			Yukari_Kima.NativeFieldInfoPtr__OccupyPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, "<OccupyPosition>k__BackingField");
			Yukari_Kima.NativeMethodInfoPtr_add_OnPlayerEnterKima_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665062);
			Yukari_Kima.NativeMethodInfoPtr_remove_OnPlayerEnterKima_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665063);
			Yukari_Kima.NativeMethodInfoPtr_add_OnKimaChangePosition_Public_add_Void_Action_1_Yukari_Kima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665064);
			Yukari_Kima.NativeMethodInfoPtr_remove_OnKimaChangePosition_Public_rem_Void_Action_1_Yukari_Kima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665065);
			Yukari_Kima.NativeMethodInfoPtr_get_CanBeTrigger_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665066);
			Yukari_Kima.NativeMethodInfoPtr_set_CanBeTrigger_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665067);
			Yukari_Kima.NativeMethodInfoPtr_get_WaitChangePositionTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665068);
			Yukari_Kima.NativeMethodInfoPtr_set_WaitChangePositionTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665069);
			Yukari_Kima.NativeMethodInfoPtr_get_OccupyPosition_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665070);
			Yukari_Kima.NativeMethodInfoPtr_set_OccupyPosition_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665071);
			Yukari_Kima.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665072);
			Yukari_Kima.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665073);
			Yukari_Kima.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665074);
			Yukari_Kima.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665075);
			Yukari_Kima.NativeMethodInfoPtr_Teleport_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665076);
			Yukari_Kima.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665077);
			Yukari_Kima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr, 100665078);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000C05F4 File Offset: 0x000BE7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40356, RefRangeEnd = 40357, XrefRangeStart = 40351, XrefRangeEnd = 40356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnPlayerEnterKima(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_add_OnPlayerEnterKima_Public_add_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000C0638 File Offset: 0x000BE838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40357, XrefRangeEnd = 40362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnPlayerEnterKima(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_remove_OnPlayerEnterKima_Public_rem_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x000C067C File Offset: 0x000BE87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40367, RefRangeEnd = 40368, XrefRangeStart = 40362, XrefRangeEnd = 40367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnKimaChangePosition(Action<Yukari_Kima> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_add_OnKimaChangePosition_Public_add_Void_Action_1_Yukari_Kima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000C06C0 File Offset: 0x000BE8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40368, XrefRangeEnd = 40373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnKimaChangePosition(Action<Yukari_Kima> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_remove_OnKimaChangePosition_Public_rem_Void_Action_1_Yukari_Kima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000C0704 File Offset: 0x000BE904
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000C0740 File Offset: 0x000BE940
		public unsafe bool CanBeTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_get_CanBeTrigger_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40373, RefRangeEnd = 40374, XrefRangeStart = 40373, XrefRangeEnd = 40373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_set_CanBeTrigger_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000C0780 File Offset: 0x000BE980
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000C07BC File Offset: 0x000BE9BC
		public unsafe float WaitChangePositionTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_get_WaitChangePositionTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40374, RefRangeEnd = 40377, XrefRangeStart = 40374, XrefRangeEnd = 40374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_set_WaitChangePositionTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000C07FC File Offset: 0x000BE9FC
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x000C0838 File Offset: 0x000BEA38
		public unsafe Vector2Int OccupyPosition
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_get_OccupyPosition_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_set_OccupyPosition_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000C0878 File Offset: 0x000BEA78
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000C08AC File Offset: 0x000BEAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40394, XrefRangeEnd = 40395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000C08E0 File Offset: 0x000BEAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40395, XrefRangeEnd = 40399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000C0924 File Offset: 0x000BEB24
		[CallerCount(0)]
		public unsafe void OnTriggerExit2D(Collider2D col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000C0968 File Offset: 0x000BEB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40399, XrefRangeEnd = 40400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr_Teleport_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000C099C File Offset: 0x000BEB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Yukari_Kima.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000C09D8 File Offset: 0x000BEBD8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Yukari_Kima() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Yukari_Kima>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Yukari_Kima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00007E93 File Offset: 0x00006093
		public Yukari_Kima(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000C0A14 File Offset: 0x000BEC14
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00007E9C File Offset: 0x0000609C
		public unsafe Action<GameObject> OnPlayerEnterKima
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr_OnPlayerEnterKima);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr_OnPlayerEnterKima), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000C0A44 File Offset: 0x000BEC44
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00007EBB File Offset: 0x000060BB
		public unsafe Action<Yukari_Kima> OnKimaChangePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr_OnKimaChangePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Yukari_Kima>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr_OnKimaChangePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000C0A74 File Offset: 0x000BEC74
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00007EDA File Offset: 0x000060DA
		public unsafe bool _CanBeTrigger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__CanBeTrigger_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__CanBeTrigger_k__BackingField)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000C0A9C File Offset: 0x000BEC9C
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00007EF5 File Offset: 0x000060F5
		public unsafe float _WaitChangePositionTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__WaitChangePositionTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__WaitChangePositionTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000C0AC4 File Offset: 0x000BECC4
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00007F10 File Offset: 0x00006110
		public unsafe Vector2Int _OccupyPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__OccupyPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Yukari_Kima.NativeFieldInfoPtr__OccupyPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerEnterKima;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_OnKimaChangePosition;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr__CanBeTrigger_k__BackingField;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__WaitChangePositionTime_k__BackingField;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr__OccupyPosition_k__BackingField;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPlayerEnterKima_Public_add_Void_Action_1_GameObject_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlayerEnterKima_Public_rem_Void_Action_1_GameObject_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_add_OnKimaChangePosition_Public_add_Void_Action_1_Yukari_Kima_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnKimaChangePosition_Public_rem_Void_Action_1_Yukari_Kima_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeTrigger_Private_get_Boolean_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeTrigger_Public_set_Void_Boolean_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitChangePositionTime_Private_get_Single_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_set_WaitChangePositionTime_Public_set_Void_Single_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupyPosition_Public_get_Vector2Int_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupyPosition_Public_set_Void_Vector2Int_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Private_Void_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
