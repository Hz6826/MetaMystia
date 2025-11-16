using System;
using DayScene.Interactables.Collections.BehaviourComponents;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x02000161 RID: 353
	public class InteractableArea : MonoBehaviour
	{
		// Token: 0x060027E3 RID: 10211 RVA: 0x001233C0 File Offset: 0x001215C0
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableArea()
		{
			Il2CppClassPointerStore<InteractableArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables", "InteractableArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr);
			InteractableArea.NativeFieldInfoPtr_ON_INTERACTABLE_VISUAL_SWITCH_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "ON_INTERACTABLE_VISUAL_SWITCH_DURATION");
			InteractableArea.NativeFieldInfoPtr_showsOnInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "showsOnInteractable");
			InteractableArea.NativeFieldInfoPtr_hidesOninteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "hidesOninteractable");
			InteractableArea.NativeFieldInfoPtr_highlightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "highlightOffset");
			InteractableArea.NativeFieldInfoPtr_enabledWhenOffCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "enabledWhenOffCollider");
			InteractableArea.NativeFieldInfoPtr_uiBehaviourIndependent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "uiBehaviourIndependent");
			InteractableArea.NativeFieldInfoPtr_isEventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "isEventTrigger");
			InteractableArea.NativeFieldInfoPtr_AfterTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "AfterTrigger");
			InteractableArea.NativeFieldInfoPtr_behaviourComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "behaviourComponent");
			InteractableArea.NativeFieldInfoPtr_hideStartAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "hideStartAlpha");
			InteractableArea.NativeFieldInfoPtr_startAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "startAlpha");
			InteractableArea.NativeFieldInfoPtr_triggerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "triggerMode");
			InteractableArea.NativeFieldInfoPtr__IsInTrigger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "<IsInTrigger>k__BackingField");
			InteractableArea.NativeFieldInfoPtr__DoNotAutoFacingWhenInteract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "<DoNotAutoFacingWhenInteract>k__BackingField");
			InteractableArea.NativeFieldInfoPtr_OnTriggerEnterStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "OnTriggerEnterStateChanged");
			InteractableArea.NativeMethodInfoPtr_get_IsInTrigger_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670314);
			InteractableArea.NativeMethodInfoPtr_set_IsInTrigger_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670315);
			InteractableArea.NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670316);
			InteractableArea.NativeMethodInfoPtr_set_DoNotAutoFacingWhenInteract_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670317);
			InteractableArea.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670318);
			InteractableArea.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670319);
			InteractableArea.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670320);
			InteractableArea.NativeMethodInfoPtr_OnTriggerStay2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670321);
			InteractableArea.NativeMethodInfoPtr_add_OnTriggerEnterStateChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670322);
			InteractableArea.NativeMethodInfoPtr_remove_OnTriggerEnterStateChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670323);
			InteractableArea.NativeMethodInfoPtr_Initialize_Public_Void_EntityBehaviourComponent_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670324);
			InteractableArea.NativeMethodInfoPtr_OnInteract_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670325);
			InteractableArea.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670326);
			InteractableArea.NativeMethodInfoPtr_UpdateAvailability_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670327);
			InteractableArea.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670328);
			InteractableArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, 100670329);
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0012365C File Offset: 0x0012185C
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0012368C File Offset: 0x0012188C
		public unsafe static bool IsInTrigger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91654, XrefRangeEnd = 91656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_get_IsInTrigger_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91656, XrefRangeEnd = 91658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_set_IsInTrigger_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x001236C0 File Offset: 0x001218C0
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x001236FC File Offset: 0x001218FC
		public unsafe bool DoNotAutoFacingWhenInteract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_set_DoNotAutoFacingWhenInteract_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0012373C File Offset: 0x0012193C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91658, XrefRangeEnd = 91660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00123770 File Offset: 0x00121970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91660, XrefRangeEnd = 91672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x001237B4 File Offset: 0x001219B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91672, XrefRangeEnd = 91687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x001237F8 File Offset: 0x001219F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91687, XrefRangeEnd = 91697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_OnTriggerStay2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0012383C File Offset: 0x00121A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91706, RefRangeEnd = 91707, XrefRangeStart = 91697, XrefRangeEnd = 91706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnTriggerEnterStateChanged(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_add_OnTriggerEnterStateChanged_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00123874 File Offset: 0x00121A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91716, RefRangeEnd = 91717, XrefRangeStart = 91707, XrefRangeEnd = 91716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnTriggerEnterStateChanged(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_remove_OnTriggerEnterStateChanged_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x001238AC File Offset: 0x00121AAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91792, RefRangeEnd = 91794, XrefRangeStart = 91717, XrefRangeEnd = 91792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(EntityBehaviourComponent entityBehaviourComponent, bool isTriggerMode, bool doNotAutoFacingWhenInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityBehaviourComponent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTriggerMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotAutoFacingWhenInteract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_Initialize_Public_Void_EntityBehaviourComponent_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0012390C File Offset: 0x00121B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91794, XrefRangeEnd = 91797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_OnInteract_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00123940 File Offset: 0x00121B40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91881, RefRangeEnd = 91885, XrefRangeStart = 91797, XrefRangeEnd = 91881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(bool doHighlight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00123980 File Offset: 0x00121B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91885, XrefRangeEnd = 91910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailability(bool shouldActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr_UpdateAvailability_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x001239C0 File Offset: 0x00121BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91910, XrefRangeEnd = 91917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableArea.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x001239FC File Offset: 0x00121BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91917, XrefRangeEnd = 91925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x0001782D File Offset: 0x00015A2D
		public InteractableArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x00123A38 File Offset: 0x00121C38
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00017836 File Offset: 0x00015A36
		public unsafe static float ON_INTERACTABLE_VISUAL_SWITCH_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractableArea.NativeFieldInfoPtr_ON_INTERACTABLE_VISUAL_SWITCH_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractableArea.NativeFieldInfoPtr_ON_INTERACTABLE_VISUAL_SWITCH_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x00123A54 File Offset: 0x00121C54
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x00017844 File Offset: 0x00015A44
		public unsafe Il2CppReferenceArray<SpriteRenderer> showsOnInteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_showsOnInteractable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_showsOnInteractable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x00123A84 File Offset: 0x00121C84
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x00017863 File Offset: 0x00015A63
		public unsafe Il2CppReferenceArray<SpriteRenderer> hidesOninteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_hidesOninteractable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_hidesOninteractable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x00123AB4 File Offset: 0x00121CB4
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x00017882 File Offset: 0x00015A82
		public unsafe Vector3 highlightOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_highlightOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_highlightOffset)) = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00123ADC File Offset: 0x00121CDC
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x0001789D File Offset: 0x00015A9D
		public unsafe Il2CppReferenceArray<Collider2D> enabledWhenOffCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_enabledWhenOffCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_enabledWhenOffCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x00123B0C File Offset: 0x00121D0C
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x000178BC File Offset: 0x00015ABC
		public unsafe bool uiBehaviourIndependent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_uiBehaviourIndependent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_uiBehaviourIndependent)) = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00123B34 File Offset: 0x00121D34
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x000178D7 File Offset: 0x00015AD7
		public unsafe bool isEventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_isEventTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_isEventTrigger)) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x00123B5C File Offset: 0x00121D5C
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x000178F2 File Offset: 0x00015AF2
		public unsafe Action<bool> AfterTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_AfterTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_AfterTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x00123B8C File Offset: 0x00121D8C
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00017911 File Offset: 0x00015B11
		public unsafe EntityBehaviourComponent behaviourComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_behaviourComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityBehaviourComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_behaviourComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00123BBC File Offset: 0x00121DBC
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00017930 File Offset: 0x00015B30
		public unsafe Il2CppStructArray<float> hideStartAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_hideStartAlpha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_hideStartAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00123BEC File Offset: 0x00121DEC
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x0001794F File Offset: 0x00015B4F
		public unsafe Il2CppStructArray<float> startAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_startAlpha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_startAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x00123C1C File Offset: 0x00121E1C
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x0001796E File Offset: 0x00015B6E
		public unsafe bool triggerMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_triggerMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr_triggerMode)) = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x00123C44 File Offset: 0x00121E44
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00017989 File Offset: 0x00015B89
		public unsafe static bool _IsInTrigger_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(InteractableArea.NativeFieldInfoPtr__IsInTrigger_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractableArea.NativeFieldInfoPtr__IsInTrigger_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00123C60 File Offset: 0x00121E60
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00017997 File Offset: 0x00015B97
		public unsafe bool _DoNotAutoFacingWhenInteract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr__DoNotAutoFacingWhenInteract_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.NativeFieldInfoPtr__DoNotAutoFacingWhenInteract_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x00123C88 File Offset: 0x00121E88
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x000179B2 File Offset: 0x00015BB2
		public unsafe static Action<bool> OnTriggerEnterStateChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InteractableArea.NativeFieldInfoPtr_OnTriggerEnterStateChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractableArea.NativeFieldInfoPtr_OnTriggerEnterStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeFieldInfoPtr_ON_INTERACTABLE_VISUAL_SWITCH_DURATION;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeFieldInfoPtr_showsOnInteractable;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr_hidesOninteractable;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr_highlightOffset;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeFieldInfoPtr_enabledWhenOffCollider;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeFieldInfoPtr_uiBehaviourIndependent;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr_isEventTrigger;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_AfterTrigger;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_behaviourComponent;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_hideStartAlpha;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_startAlpha;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_triggerMode;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr__IsInTrigger_k__BackingField;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr__DoNotAutoFacingWhenInteract_k__BackingField;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr_OnTriggerEnterStateChanged;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInTrigger_Public_Static_get_Boolean_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_set_IsInTrigger_Private_Static_set_Void_Boolean_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotAutoFacingWhenInteract_Public_get_Boolean_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_set_DoNotAutoFacingWhenInteract_Private_set_Void_Boolean_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Private_Void_Collider2D_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTriggerEnterStateChanged_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTriggerEnterStateChanged_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_EntityBehaviourComponent_Boolean_Boolean_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Void_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailability_Public_Void_Boolean_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200078B RID: 1931
		[ObfuscatedName("DayScene.Interactables.InteractableArea+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A338 RID: 41784 RVA: 0x002AD0E0 File Offset: 0x002AB2E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr);
				InteractableArea.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9");
				InteractableArea.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__27_0");
				InteractableArea.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__27_1");
				InteractableArea.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__27_2");
				InteractableArea.__c.NativeFieldInfoPtr___9__27_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__27_3");
				InteractableArea.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__29_0");
				InteractableArea.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__29_1");
				InteractableArea.__c.NativeFieldInfoPtr___9__29_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__29_3");
				InteractableArea.__c.NativeFieldInfoPtr___9__29_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, "<>9__29_4");
				InteractableArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670331);
				InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_0_Internal_Single_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670332);
				InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_1_Internal_Single_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670333);
				InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670334);
				InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_3_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670335);
				InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_0_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670336);
				InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_1_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670337);
				InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_3_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670338);
				InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_4_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr, 100670339);
			}

			// Token: 0x0600A339 RID: 41785 RVA: 0x002AD274 File Offset: 0x002AB474
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableArea.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A33A RID: 41786 RVA: 0x002AD2B0 File Offset: 0x002AB4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91589, XrefRangeEnd = 91590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _Initialize_b__27_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_0_Internal_Single_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A33B RID: 41787 RVA: 0x002AD300 File Offset: 0x002AB500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _Initialize_b__27_1(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_1_Internal_Single_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A33C RID: 41788 RVA: 0x002AD350 File Offset: 0x002AB550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91590, XrefRangeEnd = 91599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__27_2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A33D RID: 41789 RVA: 0x002AD394 File Offset: 0x002AB594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91599, XrefRangeEnd = 91608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__27_3(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__Initialize_b__27_3_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A33E RID: 41790 RVA: 0x002AD3D8 File Offset: 0x002AB5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91608, XrefRangeEnd = 91614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType1<SpriteRenderer, float> _SetSelected_b__29_0(SpriteRenderer a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_0_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType1<SpriteRenderer, float>>(intPtr3) : null;
			}

			// Token: 0x0600A33F RID: 41791 RVA: 0x002AD438 File Offset: 0x002AB638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91614, XrefRangeEnd = 91620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetSelected_b__29_1(__f__AnonymousType1<SpriteRenderer, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_1_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A340 RID: 41792 RVA: 0x002AD47C File Offset: 0x002AB67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91620, XrefRangeEnd = 91626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType1<SpriteRenderer, float> _SetSelected_b__29_3(SpriteRenderer a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_3_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType1<SpriteRenderer, float>>(intPtr3) : null;
			}

			// Token: 0x0600A341 RID: 41793 RVA: 0x002AD4DC File Offset: 0x002AB6DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91626, XrefRangeEnd = 91632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetSelected_b__29_4(__f__AnonymousType1<SpriteRenderer, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c.NativeMethodInfoPtr__SetSelected_b__29_4_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A342 RID: 41794 RVA: 0x000582C6 File Offset: 0x000564C6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035D9 RID: 13785
			// (get) Token: 0x0600A343 RID: 41795 RVA: 0x002AD520 File Offset: 0x002AB720
			// (set) Token: 0x0600A344 RID: 41796 RVA: 0x000582CF File Offset: 0x000564CF
			public unsafe static InteractableArea.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableArea.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DA RID: 13786
			// (get) Token: 0x0600A345 RID: 41797 RVA: 0x002AD548 File Offset: 0x002AB748
			// (set) Token: 0x0600A346 RID: 41798 RVA: 0x000582E1 File Offset: 0x000564E1
			public unsafe static Func<SpriteRenderer, float> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DB RID: 13787
			// (get) Token: 0x0600A347 RID: 41799 RVA: 0x002AD570 File Offset: 0x002AB770
			// (set) Token: 0x0600A348 RID: 41800 RVA: 0x000582F3 File Offset: 0x000564F3
			public unsafe static Func<SpriteRenderer, float> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DC RID: 13788
			// (get) Token: 0x0600A349 RID: 41801 RVA: 0x002AD598 File Offset: 0x002AB798
			// (set) Token: 0x0600A34A RID: 41802 RVA: 0x00058305 File Offset: 0x00056505
			public unsafe static Action<SpriteRenderer> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DD RID: 13789
			// (get) Token: 0x0600A34B RID: 41803 RVA: 0x002AD5C0 File Offset: 0x002AB7C0
			// (set) Token: 0x0600A34C RID: 41804 RVA: 0x00058317 File Offset: 0x00056517
			public unsafe static Action<SpriteRenderer> __9__27_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__27_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DE RID: 13790
			// (get) Token: 0x0600A34D RID: 41805 RVA: 0x002AD5E8 File Offset: 0x002AB7E8
			// (set) Token: 0x0600A34E RID: 41806 RVA: 0x00058329 File Offset: 0x00056529
			public unsafe static Func<SpriteRenderer, float, __f__AnonymousType1<SpriteRenderer, float>> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, float, __f__AnonymousType1<SpriteRenderer, float>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035DF RID: 13791
			// (get) Token: 0x0600A34F RID: 41807 RVA: 0x002AD610 File Offset: 0x002AB810
			// (set) Token: 0x0600A350 RID: 41808 RVA: 0x0005833B File Offset: 0x0005653B
			public unsafe static Action<__f__AnonymousType1<SpriteRenderer, float>> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<__f__AnonymousType1<SpriteRenderer, float>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E0 RID: 13792
			// (get) Token: 0x0600A351 RID: 41809 RVA: 0x002AD638 File Offset: 0x002AB838
			// (set) Token: 0x0600A352 RID: 41810 RVA: 0x0005834D File Offset: 0x0005654D
			public unsafe static Func<SpriteRenderer, float, __f__AnonymousType1<SpriteRenderer, float>> __9__29_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, float, __f__AnonymousType1<SpriteRenderer, float>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E1 RID: 13793
			// (get) Token: 0x0600A353 RID: 41811 RVA: 0x002AD660 File Offset: 0x002AB860
			// (set) Token: 0x0600A354 RID: 41812 RVA: 0x0005835F File Offset: 0x0005655F
			public unsafe static Action<__f__AnonymousType1<SpriteRenderer, float>> __9__29_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<__f__AnonymousType1<SpriteRenderer, float>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractableArea.__c.NativeFieldInfoPtr___9__29_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069AE RID: 27054
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069AF RID: 27055
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040069B0 RID: 27056
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x040069B1 RID: 27057
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x040069B2 RID: 27058
			private static readonly IntPtr NativeFieldInfoPtr___9__27_3;

			// Token: 0x040069B3 RID: 27059
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x040069B4 RID: 27060
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x040069B5 RID: 27061
			private static readonly IntPtr NativeFieldInfoPtr___9__29_3;

			// Token: 0x040069B6 RID: 27062
			private static readonly IntPtr NativeFieldInfoPtr___9__29_4;

			// Token: 0x040069B7 RID: 27063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069B8 RID: 27064
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__27_0_Internal_Single_SpriteRenderer_0;

			// Token: 0x040069B9 RID: 27065
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__27_1_Internal_Single_SpriteRenderer_0;

			// Token: 0x040069BA RID: 27066
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__27_2_Internal_Void_SpriteRenderer_0;

			// Token: 0x040069BB RID: 27067
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__27_3_Internal_Void_SpriteRenderer_0;

			// Token: 0x040069BC RID: 27068
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__29_0_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0;

			// Token: 0x040069BD RID: 27069
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__29_1_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0;

			// Token: 0x040069BE RID: 27070
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__29_3_Internal___f__AnonymousType1_2_SpriteRenderer_Single_SpriteRenderer_Single_0;

			// Token: 0x040069BF RID: 27071
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__29_4_Internal_Void___f__AnonymousType1_2_SpriteRenderer_Single_0;
		}

		// Token: 0x0200078C RID: 1932
		[ObfuscatedName("DayScene.Interactables.InteractableArea+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A355 RID: 41813 RVA: 0x002AD688 File Offset: 0x002AB888
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr);
				InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr_doHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, "doHighlight");
				InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, "<>9__6");
				InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, "<>9__7");
				InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, 100670340);
				InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, 100670341);
				InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, 100670342);
				InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__5_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, 100670343);
				InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr, 100670344);
			}

			// Token: 0x0600A356 RID: 41814 RVA: 0x002AD768 File Offset: 0x002AB968
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A357 RID: 41815 RVA: 0x002AD7A4 File Offset: 0x002AB9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91632, XrefRangeEnd = 91643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetSelected_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A358 RID: 41816 RVA: 0x002AD7E8 File Offset: 0x002AB9E8
			[CallerCount(0)]
			public unsafe void _SetSelected_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A359 RID: 41817 RVA: 0x002AD81C File Offset: 0x002ABA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91643, XrefRangeEnd = 91654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetSelected_b__5(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__5_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A35A RID: 41818 RVA: 0x002AD860 File Offset: 0x002ABA60
			[CallerCount(0)]
			public unsafe void _SetSelected_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass29_0.NativeMethodInfoPtr__SetSelected_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A35B RID: 41819 RVA: 0x00058371 File Offset: 0x00056571
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035E2 RID: 13794
			// (get) Token: 0x0600A35C RID: 41820 RVA: 0x002AD894 File Offset: 0x002ABA94
			// (set) Token: 0x0600A35D RID: 41821 RVA: 0x0005837A File Offset: 0x0005657A
			public unsafe InteractableArea __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E3 RID: 13795
			// (get) Token: 0x0600A35E RID: 41822 RVA: 0x002AD8C4 File Offset: 0x002ABAC4
			// (set) Token: 0x0600A35F RID: 41823 RVA: 0x00058399 File Offset: 0x00056599
			public unsafe bool doHighlight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr_doHighlight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr_doHighlight)) = value;
				}
			}

			// Token: 0x170035E4 RID: 13796
			// (get) Token: 0x0600A360 RID: 41824 RVA: 0x002AD8EC File Offset: 0x002ABAEC
			// (set) Token: 0x0600A361 RID: 41825 RVA: 0x000583B4 File Offset: 0x000565B4
			public unsafe Action __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035E5 RID: 13797
			// (get) Token: 0x0600A362 RID: 41826 RVA: 0x002AD91C File Offset: 0x002ABB1C
			// (set) Token: 0x0600A363 RID: 41827 RVA: 0x000583D3 File Offset: 0x000565D3
			public unsafe Action __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass29_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069C0 RID: 27072
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040069C1 RID: 27073
			private static readonly IntPtr NativeFieldInfoPtr_doHighlight;

			// Token: 0x040069C2 RID: 27074
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040069C3 RID: 27075
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040069C4 RID: 27076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069C5 RID: 27077
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__2_Internal_Void_SpriteRenderer_0;

			// Token: 0x040069C6 RID: 27078
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__6_Internal_Void_0;

			// Token: 0x040069C7 RID: 27079
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__5_Internal_Void_SpriteRenderer_0;

			// Token: 0x040069C8 RID: 27080
			private static readonly IntPtr NativeMethodInfoPtr__SetSelected_b__7_Internal_Void_0;
		}

		// Token: 0x0200078D RID: 1933
		[ObfuscatedName("DayScene.Interactables.InteractableArea+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A364 RID: 41828 RVA: 0x002AD94C File Offset: 0x002ABB4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableArea>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr);
				InteractableArea.__c__DisplayClass30_0.NativeFieldInfoPtr_shouldActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr, "shouldActive");
				InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr, 100670345);
				InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__UpdateAvailability_b__0_Internal_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr, 100670346);
				InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__UpdateAvailability_b__1_Internal_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr, 100670347);
			}

			// Token: 0x0600A365 RID: 41829 RVA: 0x002AD9C8 File Offset: 0x002ABBC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableArea.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A366 RID: 41830 RVA: 0x002ADA04 File Offset: 0x002ABC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateAvailability_b__0(Collider2D x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__UpdateAvailability_b__0_Internal_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A367 RID: 41831 RVA: 0x002ADA48 File Offset: 0x002ABC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateAvailability_b__1(Collider2D x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableArea.__c__DisplayClass30_0.NativeMethodInfoPtr__UpdateAvailability_b__1_Internal_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A368 RID: 41832 RVA: 0x000583F2 File Offset: 0x000565F2
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035E6 RID: 13798
			// (get) Token: 0x0600A369 RID: 41833 RVA: 0x002ADA8C File Offset: 0x002ABC8C
			// (set) Token: 0x0600A36A RID: 41834 RVA: 0x000583FB File Offset: 0x000565FB
			public unsafe bool shouldActive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass30_0.NativeFieldInfoPtr_shouldActive);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableArea.__c__DisplayClass30_0.NativeFieldInfoPtr_shouldActive)) = value;
				}
			}

			// Token: 0x040069C9 RID: 27081
			private static readonly IntPtr NativeFieldInfoPtr_shouldActive;

			// Token: 0x040069CA RID: 27082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069CB RID: 27083
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAvailability_b__0_Internal_Void_Collider2D_0;

			// Token: 0x040069CC RID: 27084
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAvailability_b__1_Internal_Void_Collider2D_0;
		}
	}
}
